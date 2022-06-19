using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message) //tüm bilgileri verdiği versiyon ... data , işlem sonucu , mesaj 
        {

        }

        public SuccessDataResult(T data):base(data,true) // data , işlem sonucu
        {

        }

        public SuccessDataResult(string message):base(default,true,message)// mesaj , 
        {

        }

        public SuccessDataResult():base(default,true)// hiçbirşey vermiyor , işlem sonucu
        {

        }
    }
}
