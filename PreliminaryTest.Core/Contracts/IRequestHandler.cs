using System;
using System.Collections.Generic;
using System.Text;

namespace PreliminaryTest.Core.Contracts
{ 
    internal interface IRequestHandler<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest data);
    }
}
