using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)//ister data mesaj ver
        {

        }
        public SuccessDataResult(T data) : base(data, true)//ister sadece data ver
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)//istersen sadece mesaj
        {

        }
        public SuccessDataResult() : base(default, true)// ya da hiç birşey verme
        {

        }
    }
}
