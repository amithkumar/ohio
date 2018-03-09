/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The controller to expose the actions related to calculators and tools.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class CalculatorController : Controller
    {
        /// <summary>
        /// Returns the main page.
        /// </summary>
        /// <returns>Action result.</returns>
        [Route("Calculators")]
        public ActionResult Index()
        {
            string description = "Tool description ipsum dolor sit amet oi consectetur adipiscing elit, sed " +
                     "dloreioo eiusmod tempor incididunt ut labore et dolore magna aliqiuly.";
            var model = new List<ToolModel>
            {
                new ToolModel
                {
                    Title = "College Funding Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/museum.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Asset Allocation Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/pocket-money.png",
                    Url = Url.Action("AssetAllocationTool")
                },
                new ToolModel
                {
                    Title = "Retirement Planning Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/person-money.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/pig-money.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/hand-down.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/ball-money.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/graduation-cap.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/pocket-money.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },
                new ToolModel
                {
                    Title = "Name of the Calculator",
                    Description = description,
                    ImageUrl = "/Content/i/pig-money.png",
                    Url = Url.Action("CollegeFundingCalculator")
                },

            };
            return View(model);
        }

        /// <summary>
        /// Returns the College Funding Calculator page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult CollegeFundingCalculator()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(10);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Submits the data for College Funding Calculator.
        /// </summary>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult CollegeFundingCalculator(CollegeFundingCalculatorModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            return MvcHelper.JsonSuccessResult(new
            {
                totalCollegeCosts = "$23,123",
                collegeSavingsNeed = "$17,534",
                amountProvided = "$5,555",
                savingsPerMonth = "$911",
                lumpSumSavingsNeed = "$12,345"
            });
        }

        /// <summary>
        /// Returns the Asset Allocation Tool page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult AssetAllocationTool()
        {
            ViewBag.DesktopStep1Instructions = MvcHelper.CreateFakeInstructions(12);
            ViewBag.DesktopStep2Instructions = MvcHelper.CreateFakeInstructions(12);
            ViewBag.DesktopStep3Instructions = MvcHelper.CreateFakeInstructions(10);
            ViewBag.DesktopStep4Instructions = MvcHelper.CreateFakeInstructions(5);
            ViewBag.MobileInstructions = MvcHelper.CreateFakeInstructions(3);
            return View();
        }

        /// <summary>
        /// Submits the data for Asset Allocation Tool.
        /// </summary>
        /// <returns>JSON result.</returns>
        [HttpPost]
        public JsonResult AssetAllocationTool(AssetAllocationToolModel model)
        {
            if (!ModelState.IsValid)
            {
                return MvcHelper.JsonErrorResult("Model is invalid.");
            }

            var result = new RecommendedPortfolioModel
            {
                RecommendedPortfolio = "Aggressive",
                PortfolioModels = new List<PortfolioModel>
                {
                    new PortfolioModel
                    {
                        FundName = "International stocks",
                        Conservative = 10,
                        ModeratelyConservative = 10,
                        Moderate = 10,
                        ModeratelyAggressive = 10,
                        Aggressive = 10
                    },
                    new PortfolioModel
                    {
                        FundName = "Small-Cap Stocks",
                        Conservative = 15,
                        ModeratelyConservative = 15,
                        Moderate = 15,
                        ModeratelyAggressive = 15,
                        Aggressive = 15
                    },
                    new PortfolioModel
                    {
                        FundName = "Mid-Cap Stocks",
                        Conservative = 30,
                        ModeratelyConservative = 30,
                        Moderate = 30,
                        ModeratelyAggressive = 30,
                        Aggressive = 30
                    },
                    new PortfolioModel
                    {
                        FundName = "Large-Cap Stocks",
                        Conservative = 10,
                        ModeratelyConservative = 10,
                        Moderate = 10,
                        ModeratelyAggressive = 10,
                        Aggressive = 10
                    },
                    new PortfolioModel
                    {
                        FundName = "Asset allocation Funds",
                        Conservative = 15,
                        ModeratelyConservative = 15,
                        Moderate = 15,
                        ModeratelyAggressive = 15,
                        Aggressive = 15
                    },
                    new PortfolioModel
                    {
                        FundName = "Bonds",
                        Conservative = 30,
                        ModeratelyConservative = 30,
                        Moderate = 30,
                        ModeratelyAggressive = 30,
                        Aggressive = 30
                    },
                    new PortfolioModel
                    {
                        FundName = "FIxed account",
                        Conservative = 10,
                        ModeratelyConservative = 10,
                        Moderate = 10,
                        ModeratelyAggressive = 10,
                        Aggressive = 10
                    }
                },
                Funds = new List<PortfolioFundModel>
                {
                    new PortfolioFundModel
                    {
                        FundName = "Large Cap Stocks",
                        Value = 30,
                        Items = new List<string>
                        {
                            "Dodge & Cox Stocks",
                            "Fidelity Contrafund",
                            "Fidelity Growth Company"
                        }
                    },
                    new PortfolioFundModel
                    {
                        FundName = "Small-Cap Stocks",
                        Value = 5,
                        Items = new List<string>
                        {
                            "Ohio DC Small-Cap Growth",
                            "Ohio DC Small-Cap Value",
                            "Vanguard Small-Cap Index (VSCPX)"
                        }
                    },
                    new PortfolioFundModel
                    {
                        FundName = "Mid-Cap Stocks",
                        Value = 11,
                        Items = new List<string>
                        {
                            "Vanguard Capital Opportunity (VHCAX)"
                        }
                    },
                    new PortfolioFundModel
                    {
                        FundName = "Large Cap Stocks",
                        Value = 44,
                        Items = new List<string>
                        {
                            "Ohio DC Small-Cap Growth",
                            "Ohio DC Small-Cap Value",
                            "Vanguard Small-Cap Index (VSCPX)",
                            "Vanguard Small-Cap Index (VSCPX)"
                        }
                    },
                    new PortfolioFundModel
                    {
                        FundName = "Bonds",
                        Value = 11,
                        Items = new List<string>
                        {
                            "Ohio DC Small-Cap Growth",
                            "Ohio DC Small-Cap Value"
                        }
                    },
                    new PortfolioFundModel
                    {
                        FundName = "Mid-Cap Stocks",
                        Value = 11,
                        Items = new List<string>
                        {
                            "Vanguard Capital Opportunity (VHCAX)"
                        }
                    }
                }
            };

            return MvcHelper.JsonSuccessResult(result);
        }
    }
}