using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/skills/")]
        public IActionResult Skills()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn:</h2" +
                "<ol><li>C#</li><li>C++</li><li>python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
        [HttpGet("/skills/form/")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/formresults'>" +
            "<input type='date' name='theDate' />" +
            "<label>C#:" +
            "<select name='code1'>" +
            "<option>Learning basics</option>" +
            "<option>Making apps</option>" +
            "<option>Master Coder</option>" +
            "</select>" +
            "</label>";

            string html1 = "<label>C++:" +
            "<select name='code2'>" +
            "<option>Learning basics</option>" +
            "<option>Making apps</option>" +
            "<option>Master Coder</option>" +
            "</select>" +
            "</label>";

            string html2 = "<label>Python:" +
            "<select name='code3'>" +
            "<option>Learning basics</option>" +
            "<option>Making apps</option>" +
            "<option>Master Coder</option>" +
            "</select>" +
            "</label>" +
            "<button>Submit</button>" +
            "</form>";

            return Content(html+"\n"+html1+html2, "text/html");
        }
        [Route("/skills/formresults/")]
        public IActionResult FormResults(DateTime theDate, string code1, string code2, string code3)
        {
            string html = "<ol>" +
                "<li>C#: "+code1 +"</li>" +
                "<li>C++: "+code2+"</li>" +
                "<li>Python :"+code3+"</li>" +
                "</ol>";
            return Content(theDate.ToString("d")+"\n"+html,"text/html");

        }
    }
}
