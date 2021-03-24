using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class CategoriesController : ControllerBase
    {
        ICategoryService  _categoryService;

        public CategoriesController(ICategoryService categoryservice)
        {
            _categoryService = categoryservice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int Categoryid)
        {
            var result = _categoryService.GetAllByCategoryId(Categoryid);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    


    }
}
