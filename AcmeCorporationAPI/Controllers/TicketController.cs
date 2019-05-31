using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorporationAPI.Controllers
{
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult<Ticket> GetAll()
        {
            return new OkObjectResult(_unitOfWork.TicketRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return new ObjectResult(_unitOfWork.TicketRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody]Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                var counter = 0;

                if (_unitOfWork.ProductRepository.Find(c => c.SerialNumber.ToString() == ticket.SerialNumber) != null)
                {
                    foreach (Ticket tickets in _unitOfWork.TicketRepository.GetAll())
                    {
                        if (tickets.SerialNumber == ticket.SerialNumber)
                        {
                            counter++;
                        }
                    }
                    if (counter < 2)
                    {
                        _unitOfWork.TicketRepository.Add(ticket);
                        _unitOfWork.Complete();
                        return CreatedAtAction(nameof(GetById), new { id = ticket.Id }, ticket);
                    }
                    return BadRequest("You already used this serial number twice!");
                }
                return NotFound("Serial Number not found!");
            }
            return BadRequest(ModelState);
        }
    }
}
