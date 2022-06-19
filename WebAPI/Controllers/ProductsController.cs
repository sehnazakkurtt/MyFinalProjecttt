using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //bir class iile ilgili bilgi ve onu imzalamadır 
    public class ProductsController : ControllerBase //bir controller in controller olabilmesi için onun controllerbase den inherit edilmesi ve apicontroller gerekiyor
    {
        IProductService _productService;

        public ProductsController(IProductService productService)//ProductController a burda diyoruz  sen bir IProductService bağımlısısın ama gevşek bir bağımlılık
        {
            _productService = productService;
        }

        [HttpGet("getall")] //data ver demek
        public IActionResult GetAll()
        {
            
           var result =_productService.GetAll();
            if (result.Success) //eğer resultın durumu  başarılı ise 
            {
                return Ok(result); // o zaman return ok 200 döndür ve içinde de şu data olsun
            }
            return BadRequest(result);// geçersiz istek // değise şu datayı döndür 
        }


        [HttpGet("getbyid")]
        
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }

        [HttpPost("add")] //ben sana data vericem demek onu al sistemine ekle
        public IActionResult Add(Product product)
        {
             var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        
    }
}

