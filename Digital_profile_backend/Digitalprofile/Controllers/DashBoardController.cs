using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.IO;

namespace Digitalprofile.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DashBoardController: ControllerBase
    {
        [HttpGet(Name ="AboutMe")]
        public ActionResult<IEnumerable<string>> Get()
        {
           string filePath = Path.Join( Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Files\\Dashboardcontent.txt");
            if(!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return Ok(lines);
        }
    }
}
