using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorLibrary.Interface;
using SimpleCalculatorLibrary.Service;

namespace SimpleCalculatorApplication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {
 
        private readonly ISimpleCalculatorService _simpleCalculatorService;

        public SimpleCalculatorController()
        {
            _simpleCalculatorService = new SimpleCalculatorService();
        }

        [HttpPost]
        [Route("Addition")]
        public IActionResult AddofTwoNumbers(double value1, double value2)
        {
            try
            {
                return Ok(_simpleCalculatorService.AddService(value1, value2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Subtraction")]
        public IActionResult SubtractofTwoNumbers(double value1, double value2)
        {
            try
            {
                return Ok(_simpleCalculatorService.SubtractService(value1, value2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Multiplication")]
        public IActionResult MultiplyofTwoNumbers(double value1, double value2)
        {
            try
            {
                return Ok(_simpleCalculatorService.MultiplyService(value1, value2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Division")]
        public IActionResult DivideofTwoNumbers(double value1, double value2)
        {
            try
            {
                return Ok(_simpleCalculatorService.DivideService(value1, value2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
