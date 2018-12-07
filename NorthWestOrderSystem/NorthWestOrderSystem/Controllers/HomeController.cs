/*************
Names: Sam Gines, Hunter Riches, Michael Niemann, Taylor Bakow
Section: 2
Description: MVC application that allows customers and employees to communicate more easily as 
well as allow Seattle to communicate more easily with Sinagpore Labs. 
It is connected to a database, which is hosted on Azure. Orders can be made and stored for easy access.
****************/
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NorthWestOrderSystem.DAL;
using NorthWestOrderSystem.Models;

namespace NorthWestOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //POST
        [HttpPost]
        public async Task<ActionResult> Contact(string name, string email, string subject, string message)
        {
            ViewBag.myBag = "<h2>Thank you " + name + ".<br>We will send an email to " + email + "</h2>";
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("emailforextracredit@gmail.com");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = "<h2>" + message + "</h2>";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("emailforextracredit@gmail.com", "extracredit1");
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                }
            }
            return View("EmailConfirmation");  
        }
    }
}