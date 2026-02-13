# DocumentViewerDemo
This demo uses our DocumentViewer control to quickly add the ability of 
synchronizing ThumbnailView and WorkspaceViewer controls together.  

This means selecting a thumbnail will load the image into the main image viewer, 
and applying a command to the loaded image will reflect its change in the thumbnail.

This used to require separate ThumbnailView and WorkspaceViewer and a lot of synchronization 
code. However, the DocumentViewer control simplifies this greatly albeit at the cost 
of slightly less direct control over the inner workings of the individual viewer controls.

This is the C# version

## Prerequisites
This demo assumes you have the Atalasoft DotImage SDK installed and licensed for 
DotImage Document Imaging. Optionally, you may optionally wish to have a licnse 
for our PdfReader add-on if you would like for this demo to be able to read images 
from PDF files.

You may also request a 30 day evaluation when installing / activating.

[Download DotImage](https://www.atalasoft.com/BeginDownload/DotImageDownloadPage)

## Cloning
We recommend the following to ensure you clone with the required submodule

Example: git for windows
```bash
git clone https://github.com/AtalaSupport/DemoGallery_Desktop_DocumentViewerDemo_CS_x64.git DocumentViewerDemo
cd DocumentViewerDemo
git submodule init
git pull
```

## Last Update
2025-11-13 - TD