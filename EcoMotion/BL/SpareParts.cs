using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class SpareParts
    {
        private string idPart;
        private string namePart;
        private string price;
        private string manufcturCountry;
        private string quantity;
        private string quantityInStock;
        private string active;

        public string IdPart
        {
            set
            {
                if ((value != "") && (UTILITIES.ValidationsUtilities.IsLegalDigit(value)))
                    this.idPart = value;
                else
                    throw new Exception(" enter correct id number");
                
            }
            get
            {
                return this.idPart;

            }

        }
        public string NamePart
        {
            set
            {
                if (value != "")
                    this.namePart = value;
                else
                    throw new Exception(" enter the name of the spare Part");
                
            }
            get
            {
                return this.namePart;

            }
        }
        public string Price
        {
            set
            {
                if ((value != "")&&UTILITIES.ValidationsUtilities.IsLegalDigit(value)&&int.Parse(value)>0)
                    this.price = value;
                else
                    throw new Exception("enter the Price of the spare part");
                
            }
            get
            {
                return this.price;

            }
        }
        public string ManufcturCountry
        {
            set
            {
                if (value != "")
                    this.manufcturCountry = value;
                else
                    throw new Exception("enter the Manufctur Country correctly");
                
            }
            get
            {
                return this.manufcturCountry;

            }
        }
        public string Quantity
        {
            set
            {
                if (value != ""&&UTILITIES.ValidationsUtilities.IsLegalDigit(value)&&int.Parse(value)>0)
                    this.quantity = value;
                else
                    throw new Exception("enter the actual quantity correctly");
                
            }
            get
            {
                return this.quantity;

            }
        }
        public string QuantityInStock
        {
            set
            {
                if (value != "" && UTILITIES.ValidationsUtilities.IsLegalDigit(value) && int.Parse(value) > 0)
                    this.quantityInStock = value;
                else
                    throw new Exception("enter the quantity required in the stock correctly");
                
            }
            get
            {
                return this.quantityInStock;

            }
        }
        public string Active
        {
            set
            {
                if (value != "כן" || value != "לא")
                    this.active = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.active;

            }
        }
    }
}
