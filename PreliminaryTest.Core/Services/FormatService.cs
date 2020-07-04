using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PreliminaryTest.Core.Services
{
    public class FormatService : IFormatService
    {
        public string Replace(string preFormattedString, List<string> CharatersToBeReplaced)
        {
            //TODO Use CharatersToBeReplaced
            var postReplaceString = Regex.Replace(preFormattedString, @"\$+", "£");

            return postReplaceString;
        }
        public string Remove(string preFormattedString, List<string> CharatersToBeRemoved)
        {

            //TODO Use CharatersToBeRemoved
            var postRemoveString = Regex.Replace(preFormattedString, @"(_|4)", "");

            return postRemoveString;
        }

        public string FormatContigious(string preFormattedString)
        {
            //TODO Use CharatersToBeRemoved
            var postContigiouString = Regex.Replace(preFormattedString, @"([a-zA-Z])\1+", "$1");

            return postContigiouString;
        }

        public string Truncate(string preFormattedString, int charLengthToTruncate = 15)
        {
            if(preFormattedString.Count() > 15)
            {
                return preFormattedString.Truncate(charLengthToTruncate);
            }
            return preFormattedString;
        }
    }
}
