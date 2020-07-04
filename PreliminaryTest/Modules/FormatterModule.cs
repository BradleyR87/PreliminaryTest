using Ninject.Modules;
using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.Services;
using PreliminaryTest.Core.UseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Modules
{
    public class FormatterModule : NinjectModule
    {

        public override void Load()
        {
            Bind<IFormatService>().To<FormatService>();
            Bind<FormatListOfStringsInteractor>().ToSelf().InSingletonScope();
        }
    }
}
