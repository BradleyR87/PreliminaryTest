using PreliminaryTest.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Core.DataTransferObjects
{
    public class FormatStringsRequestMessage 
    {
        public List<string> CharacterToReplace { get; private set; }
        public List<string> CharacterToRemove { get; private set; }
        public List<string> PreFormattedStrings { get; private set; }

        public FormatStringsRequestMessage(List<string> preFormattedStrings)
        {
            PreFormattedStrings = preFormattedStrings;
        }
    }
}
