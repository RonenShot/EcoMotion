using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Sale
    {

        private string code;
        private string customerID;
        private string companyNumber;
        private string totalCost;
        private string dateSale;
        private string timeSale;
        private string paymentMethod;
        public string Code
        {
            set
            {
                if (int.Parse(value)<0)
                    throw new Exception(" enter correct sale Identification number");
                this.code = value;
            }
            get
            {
                return this.code;

            }
        }
        public string CustomerID
        {
            set
            {
                if ((value == " ") && (UTILITIES.ValidationsUtilities.LegalId(value)))
                    throw new Exception(" enter correct id");
                this.customerID = value;
            }
            get
            {
                return this.customerID;

            }
        }
        public string CompanyNumber
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter correct compay number");
                this.companyNumber = value;
            }
            get
            {
                return this.companyNumber;

            }
        }
        public string TotalCost
        {
            set
            {
                if (double.Parse(value)<0)
                    throw new Exception(" enter correct compay number");
                this.totalCost = value;
            }
            get
            {
                return this.totalCost;

            }
        }
        

    }
}
