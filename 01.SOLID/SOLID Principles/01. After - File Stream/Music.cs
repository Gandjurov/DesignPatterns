using OpenClosedFileDownloadAfter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedFileDownloadAfter
{
    public class Music : IResult
    {
        public int Length { get; set; }

        public int Sent { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
