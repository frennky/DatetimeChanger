using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeChanger
{
    class DatetimeUpdater
    {
        // See https://www.exiv2.org/tags.html for more details
        public const int EXIF_PHOTO_DATETIME_ORIGINAL = 0x9003;
        public const int EXIF_PHOTO_DATETIME_DIGITIZED = 0x9004;

        public const string DATETIME_FORMAT = "yyyy:MM:dd HH:mm:ss";
        public DateTime RecordedDatetime { get; private set; }
        public DateTime RealDatetime { get; private set; }
        public string Path { get; private set; }
        public DatetimeUpdater(DateTime recordedDatetime, DateTime realDatetime, string path)
        {
            RecordedDatetime = recordedDatetime;
            RealDatetime = realDatetime;
            Path = File.Exists(path) ? path : throw new FileNotFoundException($"File {path} not found.");
        }

        private TimeSpan GetDatetimeDifferance()
        {
            return RealDatetime - RecordedDatetime;
        }

        public Task UpdateAsync()
        {
            var fileInfo = new FileInfo(Path);
            switch (fileInfo.Extension.ToLower())
            {
                case ".jpg":
                    UpdateDateTaken();
                    break;

                case ".mp4":
                    UpdateDateEncoded();
                    break;

                default:
                    break;
            }
            return Task.CompletedTask;
        }

        private void UpdateDateEncoded()
        {
            var file = ShellObject.FromParsingName(Path);
            var differance = GetDatetimeDifferance();
            var correctDateEncoded = file.Properties.System.Media.DateEncoded.Value.Value.Add(differance);
            file.Properties.System.Media.DateEncoded.Value = correctDateEncoded;
        }

        private void UpdateDateTaken()
        {
            using (var image = Image.FromFile(Path))
            {
                var dateTimeOriginalProperty = image.GetPropertyItem(EXIF_PHOTO_DATETIME_ORIGINAL);
                var dateTimeDigitizedProperty = image.GetPropertyItem(EXIF_PHOTO_DATETIME_DIGITIZED);

                var datetimeString = Encoding.ASCII.GetString(dateTimeOriginalProperty.Value);
                var datetime = DateTime.ParseExact(datetimeString.Trim('\0'), DATETIME_FORMAT, CultureInfo.InvariantCulture);
                var differance = GetDatetimeDifferance();
                var correctDatetime = datetime.Add(differance);
                var correctDatetimeBytes = Encoding.ASCII.GetBytes(correctDatetime.ToString(DATETIME_FORMAT) + '\0');

                dateTimeOriginalProperty.Value = correctDatetimeBytes;
                dateTimeDigitizedProperty.Value = correctDatetimeBytes;

                image.SetPropertyItem(dateTimeOriginalProperty);
                image.SetPropertyItem(dateTimeDigitizedProperty);
                image.Save($"{Path}.new");
            }

            File.Move($"{Path}.new", Path, true);
        }
    }
}
