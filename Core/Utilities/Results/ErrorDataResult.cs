using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {

        public ErrorDataResult(T data, string message) : base(data, false, message)//ister data mesaj ver
        {

        }
        public ErrorDataResult(T data) : base(data, false)//ister sadece data ver
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)//istersen sadece mesaj
        {

        }
        public ErrorDataResult() : base(default, false)// ya da hiç birşey verme
        {

        }
    }
}
