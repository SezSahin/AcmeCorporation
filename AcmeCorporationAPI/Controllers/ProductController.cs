using System;
using System.Collections.Generic;
using AutoMapper;
using Contracts;
using Entities.Model;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorporationAPI.Controllers
{
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_unitOfWork.ProductRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return new ObjectResult(_unitOfWork.ProductRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody][Bind("Name", "Description")]Product product)
        {
            _unitOfWork.ProductRepository.Add(product);
            _unitOfWork.Complete();
            return CreatedAtAction(nameof(GetById), new { id = product.SerialNumber }, product);
        }
    }
}
