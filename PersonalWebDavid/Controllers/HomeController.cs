using Newtonsoft.Json;
using PersonalWebDavid.Filters;
using PersonalWebDavid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace PersonalWebDavid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            return View("Index");
        }

        public ActionResult About()
        {
            return View("about");
        }


        public ActionResult Projects()
        {
            return View("projects");
        }

        //public ActionResult Blog()
        //{
        //    return View("blog");
        //}

        public ActionResult cv(string forWho, string code)
        {
            // Set visivility of message
            ViewBag.successMessage = TempData["successDownload"];
            ViewBag.failMessage = TempData["failDownload"];
            // return
            return View(
                "cv",
                new Cv() { Code = code, ForWho = forWho });
        }

        [HttpPost]
        [ActionName("davidAlcocer-CV")]
        public ActionResult cvPost(string language, Cv cv)
        {
            string classShowMessage = "showDownMessage";
            Boolean downLoadOk = true;

            try
            {
                string codeFromWebConfig = WebConfigurationManager.AppSettings["code"];

                // Validate field, downLoadOk boolean is set to false if validation fails
                if (!ModelState.IsValid
                    || cv.Code != codeFromWebConfig)
                {
                    downLoadOk = false;
                    throw new Exception();
                }

                // Show success message
                TempData["successDownload"] = classShowMessage;

                // If code is ok, return file and send email with data
                if (downLoadOk)
                {

                    string fileName = language == "en"
                        ? HttpContext.Server.MapPath(url.url.downloadCvEn)
                        : HttpContext.Server.MapPath(url.url.downloadCVEs);

                    string message = EmailContactForm.sendEmail("davidalcocerinfo@gmail.com", "ingmoyete@gmail.com", cv.Code,
                                                "david5717info6828", "someone download your cv. Code used: " + cv.Code + ". Name: " + cv.ForWho, "Error", "Success", cv.ForWho);
                    return File(fileName, MimeMapping.GetMimeMapping(fileName));
                }

            }

            catch (Exception)
            {
                TempData["failDownload"] = classShowMessage;
            }

            return Redirect("/" + language + "/" + url.url.cvPage);
        }

        public ActionResult Contact()
        {
            ViewBag.successMessage = TempData["successMessage"];
            ViewBag.failMessage = TempData["failMessage"];
            ViewBag.googleMessage = TempData["failGoogleMessage"];

            return View("contact", new ContactForm());
        }

        [HttpPost]
        public ActionResult contactPost(string language, ContactForm contactForm)
        {
            try
            {
                // Google recatpcha
                var response = Request["g-recaptcha-response"];
                const string secret = "6LfPQyATAAAAAIOgds7of8IUKwEnxQDS16sPWcxR";
                var reply = new WebClient().DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
                    secret, response));
                var capchaResponse = JsonConvert.DeserializeObject<catcha>(reply);

                // Validate form fields
                if (!ModelState.IsValid
                    || string.IsNullOrEmpty(contactForm.Email)
                    || string.IsNullOrEmpty(contactForm.Subject)
                    || string.IsNullOrEmpty(contactForm.TextArea))
                {
                    // Show error
                    TempData["failMessage"] = "showMessage";
                    throw new Exception();
                }

                // Validate capcha
                if (!capchaResponse.Success)
                {
                    TempData["failGoogleMessage"] = "showGoogleDownMessage";
                    string failGoogleMessage = getGoogleError(capchaResponse); // Iam not doin nothing with it
                    throw new Exception();
                }

                // Send Email
                string message = EmailContactForm.sendEmail("davidalcocerinfo@gmail.com", "ingmoyete@gmail.com", contactForm.Subject,
                                            "david5717info6828", contactForm.TextArea, "Error", "Success", contactForm.Email);

                // Show success message
                TempData["successMessage"] = "showMessage";

            }
            catch (Exception)
            {
                // Log exception here
            }

            return Redirect("/" + language + "/" + url.url.contactSection);
        }

        public string getGoogleError(catcha catcha)
        {
            string errorMessage;
            var error = catcha.ErrorCodes[0].ToLower();
            switch (error)
            {
                case ("missing-input-secret"):
                    errorMessage = "The secret parameter is missing.";
                    break;
                case ("invalid-input-secret"):
                    errorMessage = "The secret parameter is invalid or malformed.";
                    break;

                case ("missing-input-response"):
                    errorMessage = "The response parameter is missing.";
                    break;
                case ("invalid-input-response"):
                    errorMessage = "The response parameter is invalid or malformed.";
                    break;

                default:
                    errorMessage = "Error occured. Please try again";
                    break;                  
            }

            return errorMessage;
        }

    }
}