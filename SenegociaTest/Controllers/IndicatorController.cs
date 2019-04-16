using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using SenegociaTest.Entities;
using SenegociaTest.Helpers;
using SenegociaTest.Services;

namespace SenegociaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicatorController : ControllerBase
    {
        private IConfiguration _configuration { get; }
        private IIndicatorService _indicatorService;

        public IndicatorController(IIndicatorService indicatorService, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._indicatorService = indicatorService;
        }

        // GET api/indicator/uf
        [Authorize]
        [HttpGet("uf")]
        public ActionResult<Indicator> Get([FromQuery] string dateInput)
        {
            DateTime date;
            if (!DateTime.TryParse(dateInput, out date))
                return BadRequest(new { message = ErrorMessage.IncorrectDate });

            var url = _configuration.GetSection("IndicatorsUrl").Get<string>();
            var indicator = _indicatorService.ConsultUFValue(date, url);
            return indicator;
        }
    }
}