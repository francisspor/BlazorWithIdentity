using BlazorWithIdentity.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorWithIdentity.Server.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class QuestionsController
    {
        [HttpGet("[action]")]
        public IEnumerable<Question> GetQuestions()
        {
            return new List<Question> {
                new Question
                {
                    Text = "What color is the sky?",
                    Description = "A common question from young children.",
                    QuestionType = QuestionType.Text,
                    Required = false
                },
                new Question
                {
                    Text = "What's the answer to life, the universe and everything?",
                    Description = "A question for Deep Thought.",
                    QuestionType = QuestionType.Text,
                    Required = true
                },

            };
        }
    }
}
