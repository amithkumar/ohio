/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The controller to expose the actions related to investments.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class InvestmentController : Controller
    {
        /// <summary>
        /// Returns the main page.
        /// </summary>
        /// <returns>Action result.</returns>
        public ActionResult Index()
        {
            var model = new InvestmentsModel();
            model.ReimbursementRates = new List<FeeReimbursementRateModel>
            {
                new FeeReimbursementRateModel { InvestmentManager = "Dodhe and Cox Stock", AnnualRebrate = 0.16m },
                new FeeReimbursementRateModel { InvestmentManager = "Hartford Small Company", AnnualRebrate = 0.16m },
                new FeeReimbursementRateModel { InvestmentManager = "Fidelity Contrafund", AnnualRebrate = 0.16m },
                new FeeReimbursementRateModel { InvestmentManager = "Fidelity Growth Company", AnnualRebrate = 0.16m },
                new FeeReimbursementRateModel { InvestmentManager = "Fidelity Growth Company", AnnualRebrate = 0.16m }
            };

            model.Date = new DateTime(2017, 7, 31);
            model.PreviousQuarterYield = 2.2m;
            model.CurrentQuarterYield = 2.3m;

            model.InternationalStocks = new List<StockModel>
            {
                new StockModel
                {
                     InvestmentOption = "TEMPLETON FOREIGN",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "7.25",
                     FiveYearValue = "3.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "VANGUARD INTERNATIONAL GROWTH",
                     CurrentPrice = "$3.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "2.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "VANGUARD TOTAL INTERNATIONAL STOCK INDEX",
                     CurrentPrice = "$3.500K",
                     HalfYearPrice = "$5.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "9.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
            };

            model.SmallCapStocks = new List<StockModel>
            {
                new StockModel
                {
                     InvestmentOption = "FPA CAPITAL",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "6.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "VANGUARD SMALL CAP INDEX",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "HARTFORD SMALL OMPANY",
                     CurrentPrice = "$16.500K",
                     HalfYearPrice = "$4.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
            };

            model.MidCapStocks = new List<StockModel>
            {
                new StockModel
                {
                     InvestmentOption = "TEMPLETON FOREIGN",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                }
            };

            model.LargeCapStocks = new List<StockModel>
            {
                new StockModel
                {
                     InvestmentOption = "DODGE & COX STOCK",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "FIDELITY CONTRAFUND",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "6.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                },
                new StockModel
                {
                     InvestmentOption = "FIDELITY GROWTH COMPANY",
                     CurrentPrice = "$6.500K",
                     HalfYearPrice = "$6.500K",
                     OneYearValue = "2.25",
                     ThreeYearValue = "8.25",
                     FiveYearValue = "10.26",
                     SinceAdoption = "N/A",
                     AdoptionDate = "N/A",
                     ExpenseRatio = "0.93"
                }
            };


            return View(model);
        }
    }
}