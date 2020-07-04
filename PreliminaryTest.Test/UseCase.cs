using Moq;
using NUnit.Framework;
using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PreliminaryTest.Test
{
    [TestFixture]
    public class UseCase
    {
        private FormatListOfStringsInteractor _interactor;
        private List<string> mockCharToBeRemoved = new List<string>()
        {
            "AA",
        };
        private List<string> mockListOfStringToBeFormatted = new List<string>()
        {
            "AAAc91 % cWwWkLq$1ci3_848v3d__K",
            "AAAc91£££cWwWkLq$1ci3_848v3d__KAAAc91£££cWwWkLq$1ci3_848v3d__K"
        };

        [OneTimeSetUp]
        public void SetUp()
        {
            var mock = new Mock<IFormatService>();
            mock.Setup(service => service.Remove(It.IsAny<string>(), mockCharToBeRemoved)).Returns("AAAc91%cWwWkLq$1ci388v3dKKbb");
            _interactor = new FormatListOfStringsInteractor(mock.Object);
        }

        [Test]
        public void Handles_Null()
        {
            Assert.Throws<ArgumentNullException>(() => _interactor.Handle(new Core.DataTransferObjects.FormatStringsRequestMessage(null)));
        }

        [Test]
        public void Returns_Value()
        {
            Assert.NotNull(_interactor.Handle(new Core.DataTransferObjects.FormatStringsRequestMessage(mockListOfStringToBeFormatted)));
        }



    }
}
