using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using AstroWorldZodiac.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AstroWorldZodiac.Models;
using AstroWorldZodiac.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace AstroWorldZodiac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext, UserManager<User> userManager)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Zodiacs()
        {
            return View();
        } public IActionResult Virgo()
        {
            return View();
        } public IActionResult Libra()
        {
            return View();
        } public IActionResult Scorpio()
        {
            return View();
        } public IActionResult Sagittarius()
        {
            return View();
        } public IActionResult Capricorn()
        {
            return View();
        } public IActionResult Aquarius()
        {
            return View();
        } public IActionResult Pisces()
        {
            return View();
        } public IActionResult Aries()
        {
            return View();
        } public IActionResult Taurus()
        {
            return View();
        } public IActionResult Gemini()
        {
            return View();
        } public IActionResult Cancer()
        {
            return View();
        } 

        public IActionResult Gemestone()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            var mail = new MailMessage
            {
                IsBodyHtml = true,
                From = new MailAddress("noreply.sahiwaltextiles@gmail.com", "AstroWorld Zodiac Support")
            };

            //Send to the member's email address
            mail.To.Add("anoshaaziz09@gmail.com");

            //Subject
            mail.Subject = $"{model.Type} Inquiry from {model.Name}";

            //Reset link


            //HTML Message
            mail.Body = "<h3>Message via contact form on AstroWorld Zodiac</h3>" +
                        "<p>Here is the detail:</p><br/><br />" + $"<strong>Name:</strong> {model.Name} <br /><br />" +
                        $"<strong>Email:</strong> {model.Email} <br /><br />" +
                        $"<strong>Type:</strong> {model.Type} <br /><br />" +
                        $"<strong>Message:</strong><p> {model.Message} </p>";

            //var smtp = new SmtpClient();
            mail.IsBodyHtml = true;

            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("noreply.sahiwaltextiles@gmail.com", "Admin$123");

                try
                {
                    smtpClient.Send(mail);
                    ViewBag.Success = true;
                    //Clear the Model.
                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    // ignored
                }
                finally
                {
                    mail.Dispose();
                }

            }
            return View();
        }
        public IActionResult Appointment(int? gemStoneId)
        {
            var model = new Appointment();
            if (gemStoneId.HasValue && gemStoneId > 0)
            {
                model.GemStoneId = gemStoneId;
            }
            ViewBag.GemStones = _dbContext.GemStone.ToList();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Appointment(Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                return View(appointment);
            }

            appointment.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _dbContext.Add(appointment);
            _dbContext.SaveChanges();

            ViewBag.Success = true;
            //Clear the Model.
            ModelState.Clear();
            return View();
        }
        public IActionResult Mantra()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Astrology()
        {
            return View();
        }
        [Authorize]
        public IActionResult Feedbacks()
        {
            return View();
        }
        [Authorize]
        public IActionResult Status()
        {
           var model = new AppointmentStatusViewModel();
           var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var appointments = _dbContext.Appointments
                .Include(x=>x.GemStone)
                .Where(a=>a.UserId == userId)
                .OrderByDescending(x=>x.AppointmentDate);
            model.Appointments = appointments.ToList();
            return View(model);
        }
         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        [Authorize]
        public IActionResult Feedbacks(Feedback feed )
        {
            if (!ModelState.IsValid)
            {
                return View(feed);
            }
            feed.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _dbContext.Add(feed);
            _dbContext.SaveChanges();
            ViewBag.Success = true;
            //Clear the Model.
            ModelState.Clear();
            return View();
        }
    }

    
}
