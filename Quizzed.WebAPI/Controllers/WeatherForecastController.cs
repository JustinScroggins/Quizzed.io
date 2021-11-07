using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quizzed.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizzed.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _repository.Answer.ToString();
            _repository.Concept.ToString();
            _repository.Question.ToString();
            _repository.Quiz.ToString();
            _repository.Subject.ToString();

            return new string[] { "value1", "value2" };
        }
    }
}
