using NUnit.Framework;
using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.Services;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PreliminaryTest.Test
{
    [TestFixture]
    public class ServiceTest
    {
        private List<string> mockCharToBeRemoved = new List<string>()
        {
            "AA",
        };
        private IFormatService _service;
        [SetUp]
        public void SetUp()
        {
            _service = new FormatService();
        }

        [Test]
        public void Service_Removes_Characters()
        {
            
            Assert.IsTrue(_service.Remove(Constants.DefaultInputString, mockCharToBeRemoved) == Constants.DefaultInputPostRemoveString);
        }

        [Test]
        public void Service_Removes_Underscores()
        {
            Assert.IsTrue(_service.Remove("_", mockCharToBeRemoved) == "");
        }

        [Test]
        public void Service_Removes_4()
        {
            Assert.IsTrue(_service.Remove("4", mockCharToBeRemoved) == "");
        }

        [Test]
        public void Service_Replaces_Characters()
        {
            Assert.IsTrue(_service.Replace(Constants.DefaultInputString, mockCharToBeRemoved) == Constants.DefaultInputPostReplaceString);
        }

        [Test]
        public void Service_Replaces_Dollar_With_Pound()
        {
            Assert.IsTrue(_service.Replace("$", mockCharToBeRemoved) == "£");
        }

        [Test]
        public void Service_Formats_Contigious()
        {
            Assert.IsTrue(_service.FormatContigious(Constants.DefaultInputString) == Constants.DefaultInputPostContiguosString);
        }

        [Test]
        public void Service_Formats_Contigious_Replace_With_Same_Case_Upper()
        {
            Assert.IsTrue(_service.FormatContigious("AAAAA") == "A");
        }

        [Test]
        public void Service_Formats_Contigious_Replace_With_Same_Case_Lower()
        {
            Assert.IsTrue(_service.FormatContigious("bbbb") == "b");
        }
    }
}
