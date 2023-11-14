using System.ComponentModel.DataAnnotations;

namespace Digitalprofile.Data
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? comment { get; set; }
        public string? Email { get; set; }
        public int likenumber { get; set; }
    }

    public class Updatelikes
    {
        public int Likes { get; set; }
    }
}
