using Microsoft.AspNetCore.Mvc;
using Digitalprofile.Data;

namespace Digitalprofile.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class WorkExperienceController:ControllerBase
    {
        private static readonly DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
        List<WorkExperince> WorkExperinces =  new List<WorkExperince>()
        {
            new WorkExperince{ Years=1,StartingDate=new DateOnly(2023,03,08),EndingDate= dateOnly,Details=new List<string>{ "Spearheaded the development of a WPF (Windows Presentation Foundation) Application with MVVM Architecture as a Monitoring and Analytics tool covering 80-90% system workflows.",
                "Equipped the WPF tool with technologies like SQLite for data management and LiveChart for data visualization",
                "Assisted the QSE team in enhancing automated testing using MSTest technology. Integrated auto upgrade methods, resulting in an 80% efficiency boost, and reducing the necessity for future template creations and storage"},companyName="GE HealthCare", Role="Software Engineer"},
                new WorkExperince { Years=1,StartingDate= new DateOnly(2021,11,03),EndingDate=new DateOnly(2023,03,08),companyName="GE HealthCare",Role="Software Engineering specialist", Details= new List<string>{
                "Continuously update expertise in SQL, .NET framework, C# programming, and .NET web application development, while staying well-versed in core product functionality, usability, and features through ongoing research."," Delivered specialized technical support by proficiently debugging crash dumps along with advanced tools like WinDbg and employing various diagnostic methodologies to ensure swift and effective issue resolutions with a 100% accuracy, enhancing system performance and customer satisfaction."," Swiftly acquired proficiency in product technologies such as ASP.NET, SQL, stored procedures and Angular, demonstrating a rapid learning curve. Possess a foundational understanding of message broker software like RabbitMQ in a short span of 3 months.",
                "Implemented solutions for complex business challenges, resulting in a 95% reduction in manual by scripts to install product at the customer site silently, drastically reducing the install time by more than 60%."},
               },new WorkExperince{ Years=0.1,companyName="Tata Institute of Fundamental Research",StartingDate=new DateOnly(2019,6,10),EndingDate= new DateOnly(2019,7,10),Role="Intern",Details=new List<string>{ " Engaged in hands-on research on Muon Telescope and scintillators, demonstrating proficiency in cosmic ray research procedures, and played a key role in upgrading the electronic interface within 2 weeks." } }
        };

        [HttpGet(Name ="WorKExperience")]
        public ActionResult<IEnumerable<WorkExperince>> get()
        {
            return Ok(WorkExperinces.ToList());
        }
    }
}
