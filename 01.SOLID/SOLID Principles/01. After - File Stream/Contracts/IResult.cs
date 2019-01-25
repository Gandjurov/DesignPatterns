using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedFileDownloadAfter.Contracts
{
    public interface IResult
    {
        int Length { get; set; }

        int Sent { get; set; }
    }
}
