using Microsoft.AspNetCore.Mvc;
using NotificationAPI.Model;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;

namespace NotificationAPI.Controllers
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //[Route("GenarateOTP")]
        //public IActionResult GenarateOTP(Model.UserDetails details)

        //{
        //    LOG.WriteLog("Started");

        //    OTP OTP = new OTP();
        //   details.EmailId = "abc@gmail.com";
        //    var status = OTP.GenarateOTP();
        //    if (status != null)
        //    {
        //        LOG.WriteLog("OTP Genarated");
        //        return Ok(new response { GenarateOTP = status, StatusCode = "200", Status = "True", Message = "OTP is  genarated" });
        //    }
        //    else
        //    {
        //        LOG.WriteLog("OTP ");
        //        return Ok(new response { GenarateOTP = status, StatusCode = "422", Status = "false", Message = "OTP is not genarated", });
        //    }
        //    var a = new response { GenarateOTP = status };

        //    return Ok(a);
        // }
     
        [HttpPost]
        [Route("api/v0.0.1/notification/sendemailnotification")]
        //public ActionResult sendmail(MailRequest mailRequest)
        public Mailresponse sendmail(MailRequest mailRequest)
        {
            LOG.WriteLog("Started");

            // try
            // {
            if (ValidMail.EmailValidation(mailRequest))
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(mailRequest.ToEmail);
                    mail.From = new MailAddress("shatasree.das@indusnet.co.in");
                    mail.Subject = mailRequest.Subject;
                    //  mail.Body = mailRequest.Body + obj.GenarateOTP();
                    mail.Body = mailRequest.Body ;

                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("shatasree.das@indusnet.co.in", "wubbtgpulqqszwzs"); // Enter seders User name and password  
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    if (mailRequest!= null)
                    {
                        return (new Mailresponse { StatusCode = "200", Status = "Success", Message = "Notification Sent" });
                    LOG.WriteLog("Notification sent");
                     }
                     }
                    else
                    {
                    return new Mailresponse { StatusCode = "420", Status = "False", Message = "Mail Should be in valid format" };

                     }
                return new Mailresponse { };
            }

            //catch (Exception ex)
            //{
            //   return new Mailresponse { StatusCode = "420", Status = "False", Message = "Mail Should be in valid format" };
            //    // }



            //}
        }



    }
    //    MailMessage mail = new MailMessage();
    //    mail.To.Add(ValidMail.EmailValidation(mailRequest).ToString());
//}         //    mail.From = new MailAddress("shatasree.das@indusnet.co.in");
            //    mail.Subject = mailRequest.Subject + "Security Message";
            //  //  mail.Body = mailRequest.Body + obj.GenarateOTP();
            //    mail.Body = mailRequest.Body + "hiii Good Morning";

            //    mail.IsBodyHtml = true;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 587;
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Credentials = new System.Net.NetworkCredential("shatasree.das@indusnet.co.in", "wubbtgpulqqszwzs"); // Enter seders User name and password  
            //    smtp.EnableSsl = true;
            //    smtp.Send(mail);

               
            //}
            //catch (Exception ex)
            //{

            //}
            //LOG.WriteLog("Notification Sent");
        




    

