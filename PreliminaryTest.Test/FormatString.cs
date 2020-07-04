using Moq;
using NUnit.Framework;
using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PreliminaryTest.Core.Helper;

namespace PreliminaryTest.Test
{
    [TestFixture]
    public class FormatString
    {
        [Test]
        public void Regex_Replace_Contiguos_Character_With_Same_Case_Singular_Characther()
        {
           var matches = Regex.Replace(Constants.DefaultInputString, @"([a-zA-Z])\1+","$1");

            Assert.IsTrue(Constants.DefaultInputString != matches);
            Assert.IsTrue(matches == Constants.DefaultInputPostContiguosString);
        }

        [Test]
        public void Regex_Replace_Dollar_With_Pound()
        {
            var matches = Regex.Replace(Constants.DefaultInputString, @"\$+", "£");

            Assert.IsTrue(Constants.DefaultInputString != matches);
            Assert.IsTrue(matches == Constants.DefaultInputPostReplaceString);
        }

        [Test]
        public void Regex_Remove_Underscore_and_the_number_4()
        {
            var matches = Regex.Replace(Constants.DefaultInputString, @"(_|4)", "");

            Assert.IsTrue(Constants.DefaultInputString != matches);
            Assert.IsTrue(matches == Constants.DefaultInputPostRemoveString);
        }


        [Test]
        public void Truncate_Formatted_String()
        {
            var truncatedString = Constants.DefaultInputString.Truncate(15);

            Assert.IsTrue(truncatedString.Length == 15);
        }
    }
}
