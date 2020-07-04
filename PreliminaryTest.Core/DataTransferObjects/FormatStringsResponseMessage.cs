using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Core.DataTransferObjects
{
    public class FormatStringsResponseMessage
    {
        public List<string> FormattedStrings { get; private set; }

        public FormatStringsResponseMessage(List<string> formattedStrings)
        {
            FormattedStrings = formattedStrings;
        }

    }
}
