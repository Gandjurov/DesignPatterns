using OpenClosedFileDownloadAfter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedFileDownloadAfter
{
    public class File : IResult
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
