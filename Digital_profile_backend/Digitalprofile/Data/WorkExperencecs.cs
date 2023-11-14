namespace Digitalprofile.Data
{
    public class WorkExperince
    {
        public double Years { get; set; }
        public DateOnly StartingDate { get; set; }
        public DateOnly EndingDate { get; set; }
        public string? companyName { get; set; }
        public string? Role { get; set; }
        public List<string>? Details { get; set; }
    }
}
