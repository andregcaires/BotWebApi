using BotWebApi.Answers;
using Microsoft.AspNetCore.Mvc;

namespace BotWebApi.Controllers
{
    [Route("api/[controller]")]
    public class IntentController
    {
        [HttpGet("{intent}")]
        public string Get(string intent){
            string msg = Answer.intent(intent);;
            return $"{msg}";
        }

    }
}