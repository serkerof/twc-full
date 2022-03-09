
using System;
using System.Collections;
using System.Text;

namespace Core.Utilities.Results
{

    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}