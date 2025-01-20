using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using Shop.Models;

    [Route("categories")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return"Get";
        }

        [HttpPost]
        [Route("")]
        public string Post()
        {
            return"Post";
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return"Ola mundo!";
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return"Ola mundo!";
        }
    }