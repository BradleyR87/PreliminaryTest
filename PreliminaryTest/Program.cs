using Ninject;
using PreliminaryTest.Core;
using PreliminaryTest.Core.DataTransferObjects;
using PreliminaryTest.Core.UseCases;
using PreliminaryTest.Modules;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PreliminaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStrings = new List<string>()
            {
                "ccAAAc91 % cWwWkLq$1ci3_848v3d__Kaabbcc",
                "AAAc91£cWwWkLq$1ci3_848v3d__KAAAc91£cWwWkLq$1ci3_848v3d__K",
                "wWkLq$1ci3_848v3d__Kaabbcc",
                "aabbccAABBCC"
            };

            Console.WriteLine("Hello, Heres the list of prepopulated strings");
            inputStrings.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
           
            Console.WriteLine("On with the formatting");
            Console.WriteLine("Your Formatted strings are:");
            
            IKernel kernel = new StandardKernel(new FormatterModule());
            var useCase = kernel.Get<FormatListOfStringsInteractor>();

            var postFormattedStrings = useCase.Handle(new FormatStringsRequestMessage(inputStrings));

            foreach (var formattedString in postFormattedStrings.FormattedStrings)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(formattedString);
                Console.ResetColor();
            }
        }
    }
}
