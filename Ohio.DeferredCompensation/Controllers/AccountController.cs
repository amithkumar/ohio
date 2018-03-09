/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The controller to expose the actions related to user account.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <remarks>
    /// Changes in 1.1: https://www.topcoder.com/challenges/30062390
    /// </remarks>
    ///
    /// <author>NightWolf,TCSCODER</author>
    /// <version>1.1</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class AccountController : Controller
    {
        /// <summary>
        /// Logs in given user.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Home/Index.cshtml", model);
            }

            return RedirectToAction("Manager");
        }

        /// <summary>
        /// Returns the Signup page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Signup()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Submits sign up data from the Index page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult SignupPartial(SignupModel model)
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View("Signup", model);
        }

        /// <summary>
        /// Submits data from the Signup page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public JsonResult Signup(SignupModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult();
        }

        #region Retrieve flow

        /// <summary>
        /// Returns the Retrieve page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Retrieve()
        {
            ViewBag.Instructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Retrieves the user identifier.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult RetrieveUserId(RetrieveIdentificationModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult(new
            {
                userId = model.Username,
                email = $"{model.Username}***@example.com",
                phone = $"(+123-000-987654)"
            });
        }

        /// <summary>
        /// Sends the identification code.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult SendIdentificationCode(SendIdentificationCodeModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // send code to email/phone and save to DB here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Validates the identification code.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult ValidateIdentificationCode(ValidateIdentificationCodeModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // validate code here...

            // generate access code, that will be used to allow user to provide new password
            string accessCode = Guid.NewGuid().ToString();
            return MvcHelper.JsonSuccessResult(new { accessCode = accessCode });
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // validate access code and update password here...

            return MvcHelper.JsonSuccessResult();
        }

        #endregion

        /// <summary>
        /// Returns the Manager page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Manager()
        {
            ViewBag.Stocks = new List<AccountManagerStockModel>
            {
                new AccountManagerStockModel { Name = "International Stocks", Value = 30, ColorClass = "red-text" },
                new AccountManagerStockModel { Name = "Small-Cap Stocks", Value = 28, ColorClass = "yellow-text" },
                new AccountManagerStockModel { Name = "Large-Cap Stocks", Value = 20, ColorClass = "violet-text" },
                new AccountManagerStockModel { Name = "Asset Allocation Funds", Value = 22, ColorClass = "blue-text" },
                new AccountManagerStockModel { Name = "Bonds", Value = 10, ColorClass = "green-text" }
            };
            ViewBag.Accounts = new List<AccountManagerAccountModel>
            {
                new AccountManagerAccountModel
                {
                    AccountNumber = "1235875205",
                    AccountType = "Ohio 457",
                    EmployerName = "Name of the Employer",
                    YTDContribution = 8500,
                    Total = 50.26m,
                    CurrentBalance = 65650.35m
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "4235875205",
                    AccountType = "Utah 457",
                    EmployerName = "Name of the Employer",
                    YTDContribution = 8500,
                    Total = 10.26m,
                    CurrentBalance = 65650.35m
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "3235875205",
                    AccountType = "Texas 457",
                    EmployerName = "Name of the Employer",
                    YTDContribution = 8500,
                    Total = 50.26m,
                    CurrentBalance = 5650.35m
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "7235875205",
                    AccountType = "Ohio 457",
                    EmployerName = "Name of the Employer",
                    YTDContribution = 8500,
                    Total = 30.26m,
                    CurrentBalance = 63250.35m
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Shio 457",
                    EmployerName = "Name of the Employer",
                    YTDContribution = 2500,
                    Total = 35.26m,
                    CurrentBalance = 25650.35m
                }
            };

            return View();
        }

        /// <summary>
        /// Returns the Summary page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Summary()
        {
            var enrolledDate = new DateTime(2012, 2, 5);
            var delta = DateTime.Now.Subtract(enrolledDate);
            var model = new AccountSummaryModel
            {
                AccountNumber = "0235875205",
                Location = "OHIO 457 - STATE OF OHIO",
                AccountHolder = "Mitchel G Starc",
                EnrolledSince = enrolledDate,
                EnrolledSinceDescription = $"({delta.Days / 365 } Years {(delta.Days % 365) / 12} Months)",
                HasSmartPlan = true,
                HasAutoRebalancing = true,
                FirstYearPerformance = 5.6m,
                ThirdYearPerformance = 19.3m,
                FivthYearPerformance = 16.8m,
                TenthYearPerformance = 13.3m,
                PreTaxContribution = 200,
                YTDContribution = 8000,
                FundAssets = new List<AccountSummaryFundModel>
                {
                    new AccountSummaryFundModel
                        { FundName = "Dodhe and Cox Stock", ColorClass= "red", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Fidelity Contrafund", ColorClass= "yellow", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Fidelity Growth Company", ColorClass= "violet", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "FPA Capital", ColorClass= "blue", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Hartford Small Company", ColorClass= "green", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Ohio DC large Cap Growth", ColorClass= "cyan", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Templeton Foreign", ColorClass= "pink", Percentage = 10, Value = 2500}
                },
                FundClassifications = new List<AccountSummaryFundModel>
                {
                    new AccountSummaryFundModel
                        { FundClassification = "International stocks", ColorClass= "blue", Percentage = 5, Value = 555.55M},
                    new AccountSummaryFundModel
                        { FundClassification = "Small-cap stocks", ColorClass= "green", Percentage = 10, Value = 1111.11M},
                    new AccountSummaryFundModel
                        { FundClassification = "Mid-cap stocks", ColorClass= "yellow", Percentage = 10, Value = 1111.11M},
                    new AccountSummaryFundModel
                        { FundClassification = "Large-cap stocks", ColorClass= "red", Percentage = 10, Value = 1111.11M},
                    new AccountSummaryFundModel
                        { FundClassification = "Asset allocation stocks", ColorClass= "pink", Percentage = 30, Value = 3333.33M},
                    new AccountSummaryFundModel
                        { FundClassification = "Bonds", ColorClass= "cyan", Percentage = 20, Value = 2222.22M},
                    new AccountSummaryFundModel
                        { FundClassification = "Fixed account/cash", ColorClass= "violet", Percentage = 15, Value = 1666.66M}
                },
                PreTaxContributions = new List<AccountSummaryFundModel>
                {
                    new AccountSummaryFundModel
                        { FundName = "Dodhe and Cox Stock", ColorClass= "red", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Fidelity Contrafund", ColorClass= "yellow", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Fidelity Growth Company", ColorClass= "violet", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "FPA Capital", ColorClass= "blue", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Hartford Small Company", ColorClass= "green", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Ohio DC large Cap Growth", ColorClass= "cyan", Percentage = 10, Value = 2500},
                    new AccountSummaryFundModel
                        { FundName = "Templeton Foreign", ColorClass= "pink", Percentage = 10, Value = 2500}
                }
            };
            ViewBag.Periods = new List<string> { "YTD", "Lorem", "DTY", "TYD", "TDY" };
            return View(model);
        }

        /// <summary>
        /// Returns the Enable Summary page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult EnableSummary()
        {
            var model = new EnableSummaryModel
            {
                Frequency = "Quarterly",
                NextRebalancingDate = new DateTime(2018, 1, 1),
                LastUpdate = new DateTime(2017, 1, 1),
                TempletonForeign = 30,
                SmallCapOhioGrowth = 40,
                MidCapOhioGrowth = 30
            };

            return View(model);
        }

        /// <summary>
        /// Returns the Disable Summary page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult DisableSummary()
        {
            return View();
        }

        /// <summary>
        /// Returns the Edit Summary page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult EditSummary()
        {
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.FrequencyOptions = new List<string>
            {
                "Quaterly",
                "Lorem",
                "Quaterly",
                "Lorem",
                "Quaterly"
            };
            return View();
        }

        /// <summary>
        /// Submits data from the Edit Summary page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public JsonResult EditSummary(EditSummaryModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Returns the Smart Plan page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult SmartPlan()
        {
            ViewBag.Instructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Returns the Enrollment page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Enrollment()
        {
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(9);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.RelationTypes = new List<string> { "Spouse", "Father", "Brother", "Nephew", "Child" };
            return View();
        }

        /// <summary>
        /// Submits data from the Enrollment page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult Enrollment(EnrollmentModel model)
        {
            return RedirectToAction("Manager");
        }

        /// <summary>
        /// Returns the Statements page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Statements()
        {
            var model = new StatementModel
            {
                BigImageUrl = "/Content/i/icon-pdf.png",
                SmallImageUrl = "/Content/i/mobi/file-type.png",
                Date = new DateTime(2015, 6, 30)
            };

            ViewBag.ValidYears = new List<int> { 2016, 2015, 2014, 2013 };
            ViewBag.QuarterlyStatements = Enumerable.Repeat(model, 10).ToList();
            ViewBag.AnnualStatements = Enumerable.Repeat(model, 4).ToList();
            return View();
        }

        /// <summary>
        /// Returns the Beneficiaries page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Beneficiaries()
        {
            var model = GetTestBeneficiaries();
            return View(model);
        }

        /// <summary>
        /// Returns the Add Beneficiary page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult AddBeneficiary()
        {
            ViewBag.Instructions = MvcHelper.CreateFakeInstructions(9);
            ViewBag.RelationTypes = new List<string> { "Spouse", "Father", "Brother", "Nephew", "Child" };
            return View();
        }

        /// <summary>
        /// Submits data from the Add Beneficiary page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult AddBeneficiary(BeneficiaryModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Instructions = MvcHelper.CreateFakeInstructions(9);
                ViewBag.RelationTypes = new List<string> { "Spouse", "Father", "Brother", "Nephew", "Child" };
                return View(model);
            }

            return RedirectToAction("Beneficiaries");
        }

        /// <summary>
        /// Returns the Modify Beneficiaries page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult ModifyBeneficiaries()
        {
            var model = GetTestBeneficiaries();
            return View(model);
        }

        /// <summary>
        /// Submits data from the Modify Beneficiaries page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult ModifyBeneficiaries(IList<BeneficiaryModel> model)
        {
            return RedirectToAction("Beneficiaries");
        }

        /// <summary>
        /// Returns the Copy Beneficiaries page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult CopyBeneficiaries()
        {
            ViewBag.Beneficiaries = GetTestBeneficiaries();
            ViewBag.Accounts = new List<AccountManagerAccountModel>
            {
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Ohio 457",
                    EmployerName = "Name of the Employer"
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Roth 457",
                    EmployerName = "Name of the Employer"
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Acme 457",
                    EmployerName = "Name of the Employer"
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Lorem 457",
                    EmployerName = "Name of the Employer"
                },
                new AccountManagerAccountModel
                {
                    AccountNumber = "0235875205",
                    AccountType = "Ipsum 457",
                    EmployerName = "Name of the Employer"
                }
            };
            return View();
        }

        /// <summary>
        /// Submits data from the Copy Beneficiaries page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult CopyBeneficiaries(IList<string> accountNumbers)
        {
            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Returns the File Manager page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult FileManager()
        {
            var file = new FileModel
            {
                Id = 288,
                FileName = "FilenameloremipsumAAA.pdf",
                UploadDate = new DateTime(2017, 10, 10),
                FileSize = "88 MB",
                DocumentType = "Document Type A",
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet."
            };
            var model = Enumerable.Repeat(file, 10).ToList();
            return View(model);
        }

        /// <summary>
        /// Deletes the file with given id.
        /// </summary>
        /// <param name="fileId">The file Id.</param>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult DeleteFile(long fileId)
        {
            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Returns the Upload File page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult UploadFile()
        {
            ViewBag.DocumentTypes = new List<string>
            {
                "Document Type A",
                "Document Type B",
                "Document Type C"
            };
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(9);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Submits data from the Upload File page.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public JsonResult UploadFile(UploadFileModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            var fileIds = new List<string>();
            foreach (string fileKey in Request.Files)
            {
                var file = Request.Files[fileKey];

                // Save file here...

                // Create a fake Id for now. Replace it later with correct Id when Save file is implemented.
                string fileId = Guid.NewGuid().ToString();
                fileIds.Add(fileId);
            }

            JsonResult result = Json(fileIds);
            return result;
        }

        /// <summary>
        /// Returns the Contributions page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Contributions()
        {
            var pendingAllocation = new ContributionStockModel
            {
                FundName = "LIFEPATH 2035",
                AllocationAmount = 50,
                AllocationPercentage = 10,
                PendingAllocationAmount = 50,
                PendingAllocationPercentage = 50
            };

            var stockGroups = new List<ContributionStockGroupModel>
            {
                new ContributionStockGroupModel
                {
                    GroupName = "International Stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Templeton Foreign",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Small cap stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Large Cap Growth",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "MID cap stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Vangaurd Capital Opportunity",
                            AllocationAmount = 150,
                            AllocationPercentage = 30
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Large cap stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Dodge & Cox Stocks",
                            AllocationAmount = 0,
                            AllocationPercentage = 0
                        },
                        new ContributionStockModel
                        {
                            FundName = "Fidelity Contrafund",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Fidelity Growth Company",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Large Cap Growth",
                            AllocationAmount = 100,
                            AllocationPercentage = 20
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Asset Allocation Funds",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Lifepath 2020",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Bonds",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Intermediate Bond",
                            AllocationAmount = 0,
                            AllocationPercentage = 0
                        },
                        new ContributionStockModel
                        {
                            FundName = "Vanguard Total Bond Market Index",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                }
            };

            var model = new ContributionModel
            {
                CurrentContributionAmount = 500,
                NewContributionAmount = 500,
                NewContributionEffectiveDate = new DateTime(2017, 11, 20),
                StockGroups = stockGroups,
                PendingContributions = Enumerable.Repeat(pendingAllocation, 5).ToList()
            };

            var allStocks = model.StockGroups.SelectMany(x => x.Stocks);
            model.TotalAmount = allStocks.Sum(x => x.AllocationAmount);
            model.TotalPercentage = allStocks.Sum(x => x.AllocationPercentage);
            return View(model);
        }

        /// <summary>
        /// Returns the Edit Contribution page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult EditContribution()
        {
            var stockGroups = new List<ContributionStockGroupModel>
            {
                new ContributionStockGroupModel
                {
                    GroupName = "International Stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Templeton Foreign",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Vanguard International Growth",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Vanguard Total International Stock Index",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Small Cap Stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Small Cap Value",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Vanguard Small Cap Index",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Mid Cap Stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Vangaurd Capital Opportunity",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Large Cap Stocks",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Dodge & Cox Stocks",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Fidelity Contrafund",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Fidelity Growth Company",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Large Cap Growth",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Asset Allocation Funds",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Lifepath 2020",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Lifepath 2025",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Lifepath 2030",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Lifepath Retirement",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                },
                new ContributionStockGroupModel
                {
                    GroupName = "Bonds",
                    Stocks = new List<ContributionStockModel>
                    {
                        new ContributionStockModel
                        {
                            FundName = "Ohio DC Intermediate Bond",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        },
                        new ContributionStockModel
                        {
                            FundName = "Vanguard Total Bond Market Index",
                            AllocationAmount = 50,
                            AllocationPercentage = 10
                        }
                    }
                }
            };

            var model = new EditContributionModel
            {
                CurrentDeferralAmount = 500,
                AllocationOption = "Dollar",
                StockGroups = stockGroups
            };

            var allStocks = stockGroups.SelectMany(x => x.Stocks);
            model.TotalAmount = allStocks.Sum(x => x.AllocationAmount);
            model.TotalPercentage = allStocks.Sum(x => x.AllocationPercentage);
            ViewBag.DesktopInstructions = MvcHelper.CreateFakeInstructions(9);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Gets the preview for edited contribution.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult EditContributionPreview(EditContributionModel model)
        {
            // for now simply generate Amount and Percentage from the provided data
            var allStocks = model.StockGroups.SelectMany(x => x.Stocks);
            foreach (var item in allStocks)
            {
                item.AllocationAmount = item.NewAllocationAmount;
                item.AllocationPercentage = item.NewAllocationAmount / 5;
            }
            model.TotalAmount = allStocks.Sum(x => x.AllocationAmount);
            model.TotalPercentage = allStocks.Sum(x => x.AllocationPercentage);
            return PartialView("_EditContributionReview", model);
        }

        /// <summary>
        /// Updates the contribution.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult EditContribution(EditContributionModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Returns the Transaction History page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult TransactionHistory()
        {
            var model =
                new TransactionHistoryModel()
                {
                    FilterStartDate = (DateTime?)null,
                    FilterEndDate = (DateTime?)null,
                    Records = new List<TransactionModel>
            {
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 15),
                    FundName = "DODGE & COX STOCK",
                    Type = "Deferral",
                    Amount = 40,
                    UnitPrice = 140.2514m,
                    NumberOfUnits = 0.1234m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 20),
                    FundName = "FIDELITY CONTRAFUND",
                    Type = "Deferral",
                    Amount = 40,
                    UnitPrice = 90.2514m,
                    NumberOfUnits = 0.1333m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 12),
                    FundName = "GROWTH COMPANY",
                    Type = "Dividend",
                    Amount = 40,
                    UnitPrice = 58.2344m,
                    NumberOfUnits = 0.2115m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 24),
                    FundName = "FPA CAPITAL",
                    Type = "Admin Fee",
                    Amount = 35,
                    UnitPrice = 135.2514m,
                    NumberOfUnits = 0.1272m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 28),
                    FundName = "SMALL COMPANY",
                    Type = "Admin Fee",
                    Amount = 10,
                    UnitPrice = 10.2514m,
                    NumberOfUnits = 0.2248m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 2, 25),
                    FundName = "LIFEPATH 2020",
                    Type = "Admin Fee",
                    Amount = 42,
                    UnitPrice = 42.2514m,
                    NumberOfUnits = 0.1245m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 3, 1),
                    FundName = "LIFEPATH 2025",
                    Type = "Admin Fee",
                    Amount = 10,
                    UnitPrice = 140.2514m,
                    NumberOfUnits = 0.1245m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 3, 14),
                    FundName = "LIFEPATH RETIREMENT",
                    Type = "Fee Rabate",
                    Amount = 70,
                    UnitPrice = 120.2514m,
                    NumberOfUnits = 0.2222m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 3, 5),
                    FundName = "OHIO BOND",
                    Type = "Fee Rabate",
                    Amount = 40,
                    UnitPrice = 40.2514m,
                    NumberOfUnits = 0.1245m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 3, 8),
                    FundName = "COX STOCK",
                    Type = "Deferral",
                    Amount = 50,
                    UnitPrice = 180.2514m,
                    NumberOfUnits = 0.1335m
                },
                new TransactionModel
                {
                    Date = new DateTime(2017, 3, 10),
                    FundName = "OHIO CAP GROWTH",
                    Type = "Dividend",
                    Amount = 10,
                    UnitPrice = 140.2514m,
                    NumberOfUnits = 0.1245m
                }
                    }
                };

            return View(model);
        }

        /// <summary>
        /// Returns the Fund Exchange page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult FundExchange()
        {
            var model = new List<FundExchangeModel>
            {
                new FundExchangeModel
                {
                    ExchangeFrom = "INVESTMENT OPTION AAA",
                    ExchangeFromValue = 5,
                    ExchangeTo = new List<string> { "INVESTMENT OPTION ZZZ", "INVESTMENT OPTION YYY" },
                    ExchangeToValue = 50
                },
                new FundExchangeModel
                {
                    ExchangeFrom = "INVESTMENT OPTION BBB",
                    ExchangeFromValue = 10,
                    ExchangeTo = new List<string> { "INVESTMENT OPTION XXX", "INVESTMENT OPTION VVV" },
                    ExchangeToValue = 50
                },
                new FundExchangeModel
                {
                    ExchangeFrom = "INVESTMENT OPTION CCC",
                    ExchangeFromValue = 10,
                    ExchangeTo = new List<string> { "INVESTMENT OPTION UUU" },
                    ExchangeToValue = 50
                },
                new FundExchangeModel
                {
                    ExchangeFrom = "INVESTMENT OPTION DDD",
                    ExchangeFromValue = 5,
                    ExchangeTo = new List<string> { "INVESTMENT OPTION TTT" },
                    ExchangeToValue = 5
                }
            };

            ViewBag.ConfirmationId = "123456789";
            ViewBag.EffectiveDate = new DateTime(2017, 10, 10);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Returns the Fund Exchange Request page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult FundExchangeRequest()
        {
            var endResultModel = new EndResultExchangeModel
            {
                TempletonForeign = 10,
                OhioDCSmallCapGrowth = 5,
                VanguardCapitalOpportunity = 15,
                DodgeAndCoxStocks = 10,
                FidelityContrafund = 5,
                FidelityGrowthCompany = 5,
                OhioDCLargeCapGrowth = 15,
                Lifepath2020 = 15,
                OhioDCIntermediateBond = 10,
                VanguardTotalBondMarketIndex = 10,
                Total = 100
            };

            ViewBag.EndResultModel = endResultModel;
            ViewBag.FundNames = new List<string>
            {
                "Select",
                "Name 1",
                "Name 2",
                "Name 3"
            };

            ViewBag.DesktopEndResultStep1Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopEndResultStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.DesktopEndResultStep3Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.DesktopEndResultStepCompletedInstructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileEndResultStep3Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileEndResultStepCompletedInstructions = MvcHelper.CreateFakeInstructions(5);

            ViewBag.DesktopFundExchangeStep1Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopFundExchangeStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.DesktopFundExchangeStep3Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.DesktopFundExchangeStep4Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.DesktopFundExchangeStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopFundExchangeStepCompletedInstructions = MvcHelper.CreateFakeInstructions(4);

            ViewBag.MobileFundExchangeStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileFundExchangeStep3Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileFundExchangeStep4Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileFundExchangeStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileFundExchangeStepCompletedInstructions = MvcHelper.CreateFakeInstructions(5);

            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Requests the fund exchange.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult FundExchangeRequest(FundExchangeRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Requests the end result exchange.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult EndResultExchangeRequest(EndResultExchangeModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...

            return MvcHelper.JsonSuccessResult();
        }

        /// <summary>
        /// Returns the Withdrawals landing page.
        /// </summary>
        /// <param name="withMockWithDrawals">Indicates if we are request needs to serve some mock withdrawals 
        /// records.</param>
        /// <returns>Action result.</returns>
        public ActionResult Withdrawals(bool? withMockWithDrawals)
        {
            var model = new WithdrawalSummaryModel
            {
                AccountValue = 122120.43m,
                RequiredMinDistribution = 2000.5m,
                YearToDatePayments = 500.5m,
                RemainingRMDBalance = 1500,
            };
            if (withMockWithDrawals.GetValueOrDefault())
            {
                model.CurrentWithdrawals = new List<WithdrawalModel>
                {
                    new WithdrawalModel
                    {
                        RequestNumber = "123456789",
                        EntryDate = new DateTime(2017, 10, 10),
                        Type = "Ongoing",
                        StartDate = new DateTime(2017, 10, 10),
                        PaymentFrequency = "Monthly",
                        PaymentOption = 100,
                        Status = "Pending",
                        NextPaymentDate = new DateTime(2017, 10, 10)
                    }
                };
                model.PendingWithdrawals = new List<WithdrawalModel>
                {
                    new WithdrawalModel
                    {
                        RequestNumber = "123456789",
                        EntryDate = new DateTime(2017, 10, 10),
                        Type = "Ongoing",
                        StartDate = new DateTime(2017, 10, 10),
                        PaymentFrequency = "Monthly",
                        PaymentOption = 100,
                        Status = "Pending",
                        NextPaymentDate = new DateTime(2017, 10, 10)
                    }
                };
                ViewBag.Alerts = new List<string> { "Alert! Withdrawal will be stopped effective from 12/21/2017" };
            }
            else
            {
                model.CurrentWithdrawals = new List<WithdrawalModel>();
                model.PendingWithdrawals = new List<WithdrawalModel>();
                ViewBag.Alerts = new List<string>();
            }
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Returns the Create Withdrawal page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult CreateWithdrawal()
        {
            var model = new WithdrawalRequestModel
            {
                DepositRoutingNumber = "******0705",
                DepositBankAccount = "******1234",
                DepositBankName = "HUNTINGTON NATIONAL BANK"
            };

            ViewBag.FundNames = new List<string>
            {
                "SELECT",
                "100",
                "80",
                "50"
            };

            // User info for verification code
            ViewBag.CurrentPhoneNumber = "102-625-0254582";
            ViewBag.CurrentEmailMask = "ste***th@gmail.com";
            ViewBag.Username = "ohio-user";

            // desktop instructions
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStepCompletedInstructions = MvcHelper.CreateFakeInstructions(4);

            // mobile instructions
            ViewBag.MobileStep1Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileStep2Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.MobileStep3Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.MobileStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileStepCompletedInstructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Creates withdrawal.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult CreateWithdrawal(WithdrawalRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...
            int confirmationCode = new Random().Next(900000) + 100000;
            return MvcHelper.JsonSuccessResult(confirmationCode);
        }

        /// <summary>
        /// Returns the Edit Withdrawal page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult EditWithdrawal()
        {
            var model = new WithdrawalRequestModel
            {
                Plan = "OngoingOrRecurrentPayment",
                DepositRoutingNumber = "******6789",
                DepositBankAccount = "******1234",
                DepositBankName = "HUNTINGTON NATIONAL BANK",
                StartDate = new DateTime(2017, 10, 1),
                PaymentFrequency = "SemiAnnually",
                PaymentOption = "PercentToWithdraw",
                PaymentOptionPercentToWithdraw = 13,
                FundSelectionOption = "ChooseFund",
                FundSelectionSelectedFund = "80",
                DepositOption = "DirectDeposit",
                DepositTypeOrAccount = "Savings",
                FederalTaxExempt = true,
                MaritalStatus = true,
                FederalTaxWithholdingPercentage = 15,
                FederalTaxNumberOfAllowances = 21,
                FederalTaxAdditionalWithholding = 23,
                StateTaxExempt = false,
                StateTaxOption = "NumberOfAllowances",
                StateTaxNumberOfAllowances = 3
            };

            ViewBag.FundNames = new List<string>
            {
                "SELECT",
                "100",
                "80",
                "50"
            };

            // User info for verification code
            ViewBag.CurrentPhoneNumber = "102-625-0254582";
            ViewBag.CurrentEmailMask = "ste***th@gmail.com";
            ViewBag.Username = "ohio-user";

            // desktop instructions
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.DesktopStepCompletedInstructions = MvcHelper.CreateFakeInstructions(4);

            // mobile instructions
            ViewBag.MobileStep2Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.MobileStep3Instructions = MvcHelper.CreateFakeInstructions(3);
            ViewBag.MobileStep4Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileStep5Instructions = MvcHelper.CreateFakeInstructions(2);
            ViewBag.MobileStepCompletedInstructions = MvcHelper.CreateFakeInstructions(4);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View(model);
        }

        /// <summary>
        /// Edits withdrawal.
        /// </summary>
        /// <param name="model">The view model.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult EditWithdrawal(WithdrawalRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            // backend update code goes here...
            int confirmationCode = new Random().Next(900000) + 100000;
            return MvcHelper.JsonSuccessResult(confirmationCode);
        }

        /// <summary>
        /// Returns the Current Withdrawal page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult CurrentWithdrawal()
        {
            var model = CreateTestWithdrawal();
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(9);
            return View(model);
        }

        /// <summary>
        /// Returns the Pending Withdrawal page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult PendingWithdrawal()
        {
            var model = CreateTestWithdrawal();
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(9);
            return View(model);
        }

        /// <summary>
        /// Gets the test beneficiaries.
        /// </summary>
        /// <returns>the test beneficiaries</returns>
        private static IList<BeneficiaryModel> GetTestBeneficiaries()
        {
            return new List<BeneficiaryModel>
            {
                new BeneficiaryModel
                {
                    IsPrimary = true,
                    Name = "Monica Geller",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Spouse",
                    Percent = 45
                },
                new BeneficiaryModel
                {
                    IsPrimary = true,
                    Name = "Rachel Greene",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Child",
                    Percent = 15
                },
                new BeneficiaryModel
                {
                    IsPrimary = true,
                    Name = "Stuart Mcgrahil",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Father",
                    Percent = 15
                },
                new BeneficiaryModel
                {
                    IsPrimary = true,
                    Name = "Chandler Bing",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Child",
                    Percent = 25
                },
                new BeneficiaryModel
                {
                    Name = "Shane Watson",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Nephew",
                    Percent = 45
                },
                new BeneficiaryModel
                {
                    Name = "Shane Smith",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Child",
                    Percent = 35
                },
                new BeneficiaryModel
                {
                    Name = "Priyanka Gowti",
                    SSN = "0235874505",
                    DateOfBirth = new DateTime(1985, 1, 6),
                    Relation = "Father",
                    Percent = 20
                }
            };
        }

        /// <summary>
        /// Creates the test withdrawal.
        /// </summary>
        /// <returns>The test withdrawal.</returns>
        private static WithdrawalModel CreateTestWithdrawal()
        {
            return new WithdrawalModel
            {
                AccountValue = 122120.43m,
                StartDate = new DateTime(2017, 10, 1),
                StopDate = new DateTime(2017, 10, 1),
                PaymentFrequency = "Monthly",
                PaymentOption = 1000,
                GrossAmount = 1000,
                NetAmount = 970.4m,
                FundSelection = "All Funds(Pro-Rata)",
                DepositOption = "Direct Deposit",
                RoutingNumber = "****6789",
                BankAccountNumber = "****1234",
                BankName = "HUNTINGTON NATIONAL BANK",
                AccountType = "Checking",
                FederalTaxExempt = true,
                MaritalStatus = true,
                FederalNumberOfAllowances = 3,
                FederalAdditionalWithholding = 500,
                StateTaxExempt = true,
                StateNumberOfAllowances = 3,
                StateAdditionalWithholding = 500
            };
        }
    }
}