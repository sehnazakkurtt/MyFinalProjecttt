using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //categori ile ilgili dış dünyaya neyi servis etmek istiyorsam

        List<Category> GetAll(); //tümünü listele
        Category GetById(int categoryId);

    }
}
