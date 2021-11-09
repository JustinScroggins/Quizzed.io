using Microsoft.AspNetCore.Mvc;
using Quizzed.Contracts;
using System;

namespace Quizzed.WebAPI.Controllers
{

    [Route("api/questions")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public AnswerController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAnswers()
        {
            try
            {
                var answers = _repository.Answer.GetAllAnswers(trackChanges: false);

                return Ok(answers);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAnswers)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
