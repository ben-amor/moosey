using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Drive.v3;

namespace Moosey
{
    public class MooseyPhotoProvider
    {
        public IEnumerable<object> GetMostRecentMooseyPhotoSince(DateTime dateTime)
        {
            // TODO large preamble from https://developers.google.com/drive/v3/web/quickstart/dotnet
            var driveService = new DriveService();

        }
    }
    }
}