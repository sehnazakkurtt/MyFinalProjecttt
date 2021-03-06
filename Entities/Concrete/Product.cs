using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity  //IEntity: Bu bir veritabanı nesnesidir demek
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short  UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
