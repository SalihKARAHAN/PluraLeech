using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluraLeecher.Abstraction;
using System.IO;

namespace PluraLeecher.Helpers
{
    class FileOperationHelper : IFileOperations
    {
        public bool VideoValidation(Models.Video video, string videoLengthOnSite)
        {
            return video.VideoLength == videoLengthOnSite;
        }

        public string ReadDownloadedVideoFileInformations(string downloadedVideoPath)
        {
            FileInfo videoFileInfo = new FileInfo(downloadedVideoPath);
            if (videoFileInfo==null)
            {
                throw new FileNotFoundException("Belirtilen dizinde dosya bulunamıyor!",downloadedVideoPath);
            }
        }
    }
}
