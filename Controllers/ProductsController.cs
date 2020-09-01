using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Models;
namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli2",
            Id =1,
            Description="pretty girls",
            Price=11
             },

            new Product
            {
            Name ="zahra kabdoli3",
            Id =1,
            Description="pretty girls",
            Price=11
            },
           new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            }

        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
        [HttpGet("{id}")]
        //lab 3 working
        //test
    }
}
