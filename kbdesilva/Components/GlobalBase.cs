using kbdesilva.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace kbdesilva.Components
{
    public class GlobalBase : ComponentBase
    {
        [Inject]
        public NavigationManager navigation { get; set; }
        [Inject]
        public IJSRuntime jSRuntime { get; set; }

        public PersonalInfo Info = new()
        {
            Name = "Kim Brian De Silva",
            Title = "Software Engineer",
            Email = "desilva.kb02@gmail.com",
            Phone = "+6392-6838-9237",
            Location = "Angeles, Pampanga",
            LinkedIn = "https://www.linkedin.com/in/kbdesilva/"
        };
        public List<Project> projects = new()
        {
            new Project
            {
                Title = "HCM Evolve",
                Description = "A multi-tenant workforce management platform tailored for recruitment agencies. HCM Evolve offers real-time staff visibility, detailed employee data, and seamless timesheet processing. The platform centralizes on-hire staff information, document storage, and job allocation, enhancing productivity with comprehensive reporting and organized activity tracking. It provides clients with a dedicated portal for efficient labour hire management, ensuring safety and optimizing scheduling through instant access to vital staff details and comprehensive reporting.",
                Technologies = new[]
                {
                    "Blazor", ".NET MAUI", ".NET 6", "Entity Framework", "SQL Server", "REST APIs",
                    "JWT Authentication", "CI/CD", "Azure DevOps", "Responsive Design", "Multi-Tenant Architecture",
                    "Real-Time Staff Tracking", "Client Portal Integration", "Timesheet Management"
                }
            },
            new Project
            {
                Title = "PDS Admin Portal",
                Description = "Built internal-facing tools to manage market data, financial entities, disclosures, and trading content for the PDS website. Key features include password reset functionality, CRUD operations for market data, role-based permissions, and secure user authentication. The app utilizes Blazor Server-Side Rendering (SSR) for a highly interactive and performant user experience. Additionally, jQuery is used for certain UI interactivity and client-side enhancements.",
                Technologies = new[]
                {
                    ".NET 8", "Blazor Server", "Entity Framework Core", "REST API", "Stored Procedures", "Tailwind CSS",
                    "Role-Based Access", "JWT Authentication", "Blazor SSR", "jQuery", "CRUD Operations", "Password Reset", "Bootstrap"
                }
            },
            new Project
            {
                Title = "PDS Subscriber Portal",
                Description = "Developed subscriber-specific features such as document access, news alerts, and historical data reporting.",
                Technologies = new[]
                {
                    ".NET 8", "Blazor SSR", "JWT Authentication", "Stored Procedure", "REST API", "MySQL", "JWT Auth", "Secure File Downloads"
                }
            },
            new Project
            {
                Title = "PDS Widget",
                Description = "Created embeddable market widgets showing real-time trading stats and news summaries PDS platforms.",
                Technologies = new[]
                {
                    "VueJS", "Tailwind CSS", "Axios", "Responsive UI", "Dapper", "GraphQL.NET" , "Hot Chocolate"
                }
            },
            new Project
            {
                Title = "PDS Market Page",
                Description = "Rebuilt public-facing page for live market data, summaries, charts, and disclosures for real-time investor access.",
                Technologies = new[]
                {
                    "Blazor SSR", ".NET 8", "MySQL", "Responsive Design", "HTML5", "JWT Auth", "Tailwind CSS"
                }
            },
            new Project
            {
                Title = "PSE EQUIP",
                Description = "Contributed to EQUIP – a real-time stock tracking and analytics platform for the Philippine Stock Exchange.",
                Technologies = new[]
                {
                    "Blazor SSR", ".NET 8", "JWT Auth", "GraphQL.NET", "MySQL",
                    "SignalR", "REST APIs", "Hot Chocolate", "Tailwind CSS"
                }
            }
        };
        public string aboutMeDescription = "I am a dedicated software engineer with a deep passion for creating innovative and efficient solutions. Specializing in Blazor, .NET 8, and modern web technologies, I focus on developing scalable, high-performance applications that drive business success. With a strong foundation in backend and frontend development, I am committed to optimizing user experiences through seamless, intuitive, and responsive interfaces. My approach to software development emphasizes clean code, scalability, and collaborative teamwork, allowing me to tackle complex challenges and deliver reliable, sustainable solutions.";

        public List<WorkExperience> WorkExperiences = new()
        {
            new WorkExperience
            {
                Position = "Software Engineer",
                Company = "Premier Software Enterprise Inc.",
                Duration = "June 2024 – Present",
                Description = "Developing and maintaining the Philippine Stock Exchange's official website and trading platforms using C#, .NET 8, Blazor, MySQL, JavaScript, and Tailwind CSS. Led the modernization of the Philippine Dealing System (PDS), improving trading operations, security, and user experience."
            },
            new WorkExperience
            {
                Position = "C# .NET Developer",
                Company = "1080 Agile Pty Ltd.",
                Duration = "Feb 2022 – June 2024",
                Description = "Contributed to the development and enhancement of HCMevolve, a SaaS-based workforce management platform tailored for recruitment agencies. Developed and maintained cross-platform applications using Blazor and .NET MAUI, ensuring seamless integration across mobile and web platforms."
            }
        };

        public List<Certification> Certifications = new()
        {
            new Certification { Title = "IT Essentials: PC Hardware and Software", Provider = "Cisco Networking Academy" },
            new Certification { Title = "Cybersecurity Essentials", Provider = "Cisco Networking Academy" },
            new Certification { Title = "Database Programming with PL/SQL", Provider = "Oracle" },
            new Certification { Title = "Microsoft Technology Associate: Introduction to Programming using Python", Provider = "Microsoft" },
            new Certification { Title = "JavaScript for Beginners", Provider = "Udemy" },
            new Certification { Title = "HTML5 & CSS3 Complete Course", Provider = "Udemy" },
            new Certification { Title = "SQL Practice: Intermediate Queries", Provider = "LinkedIn Learning" }
        };

    }
}
