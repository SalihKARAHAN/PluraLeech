using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluraLeecher.Models;

namespace PluraLeecher.Abstraction
{
    public interface IFileOperations
    {
        string ReadDownloadedVideoFileInformations(string downloadedVideoPath);
        bool VideoValidation(Video video, string videoLengthOnSite);
    }
}
