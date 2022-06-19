using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        //base Result demek
        public SuccessResult(string message):base(true,message)//Base in iki parametreli olanını çalıştır 
        {

        }

        public SuccessResult():base(true) //base in tek parametli olanını çalıştır 
        {

        }
    }
}
