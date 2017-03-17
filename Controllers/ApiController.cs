using System;
using Microsoft.AspNetCore.Mvc;

namespace MaxbotChallenge.Controllers
{
    [Route("/")]
    public class ApiController : Controller
    {
        [HttpGet]
        public string Index(string question)
        {
            if (!string.IsNullOrEmpty(question)) {
                // Please insert your awesome bot logic here.
                // Below you see some sample questions with pre-filled answers.
                if (question.Equals("What time do you start the qualifying race of the Formula 1 Monaco?", StringComparison.CurrentCultureIgnoreCase)) {
                    return "13:00";
                } else if (question.Equals("What do you think of the Formula 1 Russia?", StringComparison.CurrentCultureIgnoreCase)) {
                    return "Sochi is an interesting track: a circuit with room to overtake. Hopefully we don’t need to but if it’s necessary, there are opportunities.";
                } else if (question.Equals("For which team do you race?", StringComparison.CurrentCultureIgnoreCase)) {
                    return "Red Bull Racing";
                } else if (question.Equals("Which place did you end in China in 2016?", StringComparison.CurrentCultureIgnoreCase)) {
                    return "8th";
                } else {
                    return $"Ok, I don't understand your question '{question}'.";
                }
            } else {
                return "Hi, I'm Max Verstappen. Do you have a question for me?";
            }
        }
    }
}