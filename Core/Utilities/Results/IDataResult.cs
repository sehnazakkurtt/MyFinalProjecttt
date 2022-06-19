using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //T döndüreceğim tip
    {
        T Data { get; } //  için de mesaj ve işlem sonucu dışında yukarıda belirtilen T türünde bir data olacak
    }
}
