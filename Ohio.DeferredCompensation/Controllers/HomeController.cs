/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The home controller.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class HomeController : Controller
    {
        /// <summary>
        /// Returns the main page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Index()
        {
            ViewBag.Notifications = new List<NotificationModel>
            {
                new NotificationModel
                {
                    Type = "ALERT",
                    Content ="The application will be offline for 30 minutes due to system maintenance on",
                    Date ="1 Sep 2017 11:00 PM - 11:30 PM"
                }
            };

            return View();
        }

        /// <summary>
        /// Returns the About Us page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult AboutUs()
        {
            string pic = "/Content/i/member";
            ViewBag.BoardMembers = new List<BoardMemberModel>
            {
                new BoardMemberModel { Name = "Steven Smith", Office= "Director", ImageUrl = $"{pic}01.png" },
                new BoardMemberModel { Name = "Rachel Greene", Office= "Designation", ImageUrl = $"{pic}02.png" },
                new BoardMemberModel { Name = "Joey Tribbiani", Office= "Designation", ImageUrl = $"{pic}03.png" },
                new BoardMemberModel { Name = "Monica Geller", Office= "Designation", ImageUrl = $"{pic}04.png" },
                new BoardMemberModel { Name = "Phoebe Buffay", Office= "Designation", ImageUrl = $"{pic}05.png" },
                new BoardMemberModel { Name = "Amy Jackson", Office= "Designation", ImageUrl = $"{pic}06.png" },
                new BoardMemberModel { Name = "Jennifer Anniston", Office= "Designation", ImageUrl = $"{pic}07.png" },
                new BoardMemberModel { Name = "Courtney Cox", Office= "Designation", ImageUrl = $"{pic}08.png" },
                new BoardMemberModel { Name = "Priyanka Kumari", Office= "Designation", ImageUrl = $"{pic}09.png" },
                new BoardMemberModel { Name = "Laila Luna", Office= "Designation", ImageUrl = $"{pic}10.png" },
                new BoardMemberModel { Name = "Lyna Smith", Office= "Designation", ImageUrl = $"{pic}11.png" },
                new BoardMemberModel { Name = "Shiny Smith", Office= "Designation", ImageUrl = $"{pic}12.png" },
                new BoardMemberModel { Name = "Ross Geller", Office= "Designation", ImageUrl = $"{pic}13.png" },
            };

            var meeting = new BoardMeetingModel { Date = new DateTime(2017, 1, 15, 9, 0, 0), Duration = "1 hr 30 min" };
            ViewBag.BoardMeetings = Enumerable.Repeat(meeting, 12).ToList();
            return View();
        }

        /// <summary>
        /// Returns the Contact Us page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult ContactUs()
        {
            var dateClosed = new DateTime(2017, 4, 15);
            var dateProcessed = new DateTime(2017, 4, 28);
            ViewBag.Holidays = new List<HolidayModel>
            {
                new HolidayModel { Title = "Good Friday", DateClosed = dateClosed, DateProcessed = dateProcessed },
                new HolidayModel { Title = "Memorial Day", DateClosed = dateClosed, DateProcessed = dateProcessed },
                new HolidayModel { Title = "Day before independence Day", DateClosed = dateClosed, DateProcessed = dateProcessed },
                new HolidayModel { Title = "Independence Day", DateClosed = dateClosed, DateProcessed = dateProcessed },
                new HolidayModel { Title = "Christmas Day", DateClosed = dateClosed, DateProcessed = dateProcessed },
                new HolidayModel { Title = "New Year", DateClosed = dateClosed, DateProcessed = dateProcessed },
            };
            return View();
        }

        /// <summary>
        /// Returns the Send Email page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult SendEmail()
        {
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(9);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult SendEmail(SendEmailModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(9);
                ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
                return View(model);
            }

            return RedirectToAction("Index");
        }
    }
}