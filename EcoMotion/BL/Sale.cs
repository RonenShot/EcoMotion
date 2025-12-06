using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Sale
    {

        
        
        private string totalCost;
        private string dateSale;
        private string timeSale;
        private string paymentMethod;
        
        
        public string TotalCost
        {
            set
            {
                if (int.Parse(value)>0&&UTILITIES.ValidationsUtilities.IsLegalDigit(value))
                    this.totalCost = value;
                else
                  throw new Exception("incorrect");
                
            }
            get
            {
                return this.totalCost;

            }
        }
        public string DateSale
        {
            set
            {
                if (value != "")
                    this.dateSale = value;
                else
                  throw new Exception("incorrect");
                
            }
            get
            {
                return this.dateSale;

            }
        }
        public string TimeSale
        {
            set
            {
                if (value!="")
                    this.timeSale = value;
                else
                   throw new Exception("incorrect");
                
            }
            get
            {
                return this.timeSale;

            }
        }
        public string PaymentMethod
        {
            set
            {
                if (value != "")
                    this.paymentMethod = value;
                else
                    throw new Exception("incorrect");

            }
            get
            {
                return this.paymentMethod;

            }
        }


    }
}
