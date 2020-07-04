using PreliminaryTest.Core.Contracts;
using PreliminaryTest.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreliminaryTest.Core.UseCases
{
    public class FormatListOfStringsInteractor : IRequestHandler<FormatStringsRequestMessage, FormatStringsResponseMessage>
    {
        private readonly IFormatService _formatService;

        public FormatListOfStringsInteractor(IFormatService formatService)
        {
            _formatService = formatService;
        }

        public FormatStringsResponseMessage Handle(FormatStringsRequestMessage preFormattedStrings)
        {
            if(preFormattedStrings.PreFormattedStrings == null)
            {
                throw new ArgumentNullException(nameof(preFormattedStrings));
            }

            var formattedStrings = new List<string>();
            foreach(var preFormatedstring in preFormattedStrings.PreFormattedStrings)
            {
                var PostContigious = _formatService.FormatContigious(preFormatedstring);
                var PostReplacement = _formatService.Replace(PostContigious, preFormattedStrings.CharacterToReplace);
                var PostRemove = _formatService.Remove(PostReplacement, preFormattedStrings.CharacterToRemove);
                var PostTruncate = _formatService.Truncate(PostRemove, 15);
                formattedStrings.Add(PostTruncate);
            }

            return new FormatStringsResponseMessage(formattedStrings);
        }
    }
}
