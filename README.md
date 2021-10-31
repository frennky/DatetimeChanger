# DatetiemChanger

This is a simple tool created to update video and photo datetime in case of incorrect device time settings.

Although it is rare for mobile phones to get their datetime out of sync, it can happen with other types of devices, such as cameras. There are various reasons this could happen, but when it does, all photos and videos end up with incorrect datetime. It can be frustrating finding out once you're back from vacation that all photos and videos have incorrect datetime. This tool was made to correct this issue.

## Features
- batch update based on selected path
- updates datetime original and digitized for .jpg files
- updates datetime encoded for .mp4 files
- tested primarily with media created with GoPro camera

## Usage

Once you download the executable from releases, simply run the tool. It only requires permissions to edit the files you wish to update.

There are two input values you should supply. Recorded datetime, which represents datetime that the device thinks it is currently, and real datetime, which is current datetime. This assumes that you haven't changed device datetime since the photos/videos were taken.

Once you supply those values, select the path where the files are stored and click 'Update'.

### Notice

It is advisable to have a backup of media files before you use this tool to update them.
