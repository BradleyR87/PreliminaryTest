using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Core.Entities
{
    class PreFormatted
    {
        public List<string> StringToBeFormatted { get; set; }
        public string RegexToBeUsedInFormatting { get; set; }

        public List<KeyValuePair<string, string>> CharrToBeReplaced {get; set;}
    }
}
