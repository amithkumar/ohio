/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
namespace Ohio.DeferredCompensation.Models
{
    public class AccountManagerAccountModel
    {
        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public string EmployerName { get; set; }

        public decimal YTDContribution { get; set; }

        public decimal Total { get; set; }

        public decimal CurrentBalance { get; set; }
    }
}