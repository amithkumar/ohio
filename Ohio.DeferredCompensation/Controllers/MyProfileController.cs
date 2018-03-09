/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The controller for My Profile related pages.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class MyProfileController : Controller
    {
        /// <summary>
        /// Gets the Personal Information page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult PersonalInfo()
        {
            var model = new ProfileModel
            {
                Address = "State of Ohio, 3O E Broad St. 29th fl., Columbus, Ohio, 43215",
                HomePhone = "102-658-025680",
                MobilePhone = "102-658-025680",
                EmailAddress = "steve.smith25@gmail.com",
                EmployeePhones = new List<EmployeePhoneModel>
                {
                    new EmployeePhoneModel
                    {
                        EmployeeName = "Employee Name A",
                        AccountNumber = "145628523",
                        PhoneNumber = "102-124-5210"
                    },
                    new EmployeePhoneModel
                    {
                        EmployeeName = "Employee Name B",
                        AccountNumber = "145628523",
                        PhoneNumber = "102-124-5210"
                    },
                    new EmployeePhoneModel
                    {
                        EmployeeName = "Employee Name C",
                        AccountNumber = "145628523",
                        PhoneNumber = "102-124-5210"
                    }
                }
            };

            return View(model);
        }

        /// <summary>
        /// Gets the Edit Personal Information page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult EditPersonalInfo()
        {
            ViewBag.States = new List<string> { "State", "State A", "State B", "State C", "State D" };
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Updates profile personal information.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult EditPersonalInfo(ProfileModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Change Mobile Phone page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult ChangeMobilePhone()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "102-625-0254582";
            ViewBag.CurrentEmailMask = "ste***th@gmail.com";
            ViewBag.Username = "ohio-user";
            return View();
        }

        /// <summary>
        /// Updates profile mobile phone.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult ChangeMobilePhone(ChangeProfilePhoneModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Change Email Address page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult ChangeEmailAddress()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "102-625-0254582";
            ViewBag.CurrentEmail = "stve.smith@gmail.com";
            ViewBag.CurrentEmailMask = "st****mith@gmail.com";
            ViewBag.Username = "ohio-user";
            return View();
        }

        /// <summary>
        /// Updates profile email address.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult ChangeEmailAddress(ChangeEmailModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Edit Employee Phone page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult EditEmployeePhone()
        {
            var model = new ChangeEmployeePhoneModel
            {
                EmployeeName = "Employee Name A",
                CurrentPhoneNumber = "102-625-0254582"
            };

            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Updates employee phone number.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult EditEmployeePhone(ChangeEmployeePhoneModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Login Credentials page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult LoginCredentials()
        {
            var model = new LoginModel
            {
                Username = "IornMan44",
                Password = "***********"
            };

            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Gets the Change Username page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult ChangeUsername()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "+102-652-985204";
            ViewBag.CurrentEmailMask = "st****mith@gmail.com";
            ViewBag.Username = "IronMan";
            return View();
        }

        /// <summary>
        /// Updates profile username.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult ChangeUsername(ChangeUsernameModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Change Password page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult ChangePassword()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "+102-652-985204";
            ViewBag.CurrentEmailMask = "st****mith@gmail.com";
            ViewBag.Username = "IronMan";
            return View();
        }

        /// <summary>
        /// Updates profile password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult ChangePassword(ChangeProfilePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the E-Delivery Preferences page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult EDeliveryPreferences()
        {
            var model = new EDeliveryPreferencesModel
            {
                QuarterlyStatementAndFocusNewsLetter = true
            };
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Updates profile E-Delivery preferences .
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult EDeliveryPreferences(EDeliveryPreferencesModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Bank Information page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult BankInformation()
        {
            var model = new List<BankInformationModel>
            {
                new BankInformationModel
                {
                     BankName = "City Bank Name Lores Splpern",
                     RoutingNumber = "*****0545",
                     AccountNumber = "*****4520",
                     Type = "Savings"
                }
            };

            return View(model);
        }

        /// <summary>
        /// Gets the Add Bank Information page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult AddBankInformation()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "+102-652-985204";
            ViewBag.CurrentEmailMask = "st****mith@gmail.com";
            ViewBag.Username = "IronMan";
            return View();
        }

        /// <summary>
        /// Adds bank information.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult AddBankInformation(EditBankInformationModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Gets the Edit Bank Information page.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult EditBankInformation()
        {
            var model = new EditBankInformationModel { BankName = "City Bank" };
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.CurrentPhoneNumber = "+102-652-985204";
            ViewBag.CurrentEmailMask = "st****mith@gmail.com";
            ViewBag.Username = "IronMan";
            return View(model);
        }

        /// <summary>
        /// Edits bank information.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The action result.</returns>
        [HttpPost]
        public ActionResult EditBankInformation(EditBankInformationModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }
    }
}