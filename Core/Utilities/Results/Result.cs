using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get lar readonlydirler constructor bolğu içinde set edilebilrler 
        public Result(bool success, string message):this(success) //this clasın kendisi demek
        {
            Message = message; //aşağıdaki massage yi message olarak set et
            
        }

        public Result(bool success)
        {
            Success = success; //aşağıdaki success i success olarak set et
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
