using PreliminaryTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Core.Contracts
{
    public interface IFormatService : IFormat
    {
        string Replace(string preFormattedString, List<string> CharatersToBeReplaced);
        string Remove(string preFormattedString, List<string> CharatersToBeRemoved);
        string Truncate(string preFormattedString, int charLengthToTruncate);
        string FormatContigious(string preFormattedString);
    }
}
