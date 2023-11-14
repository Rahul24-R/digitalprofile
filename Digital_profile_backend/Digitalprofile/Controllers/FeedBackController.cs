using Digitalprofile.Data;
using Microsoft.AspNetCore.Mvc;

namespace Digitalprofile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedBackController : ControllerBase {
        private readonly DataContext _context;

        public FeedBackController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult post([FromBody] Feedback Feedbackreview)
        {
            Console.WriteLine(Feedbackreview);
            if (Feedbackreview == null)
            {
                return BadRequest("Inavlid Data");
            }
            else
            {
                Feedbackreview.likenumber = 0;
                _context.UserFeedback.Add(Feedbackreview);
                _context.SaveChanges();
                return Ok(Feedbackreview);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Feedback>> get()
        {
            return Ok(_context.UserFeedback.ToList());
        }

        [HttpPut("{id}")]
        public ActionResult put(int id, [FromBody]Updatelikes likes)
        {
            var resultcomment = _context.UserFeedback.SingleOrDefault(x=>x.Id==id);
            if (resultcomment == null)
            {
                return NotFound();
            }
            else
            {
                resultcomment.likenumber = likes.Likes;
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
