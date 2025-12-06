using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Inventory
    {
        private string inventoryID;
        private string motorID;
        private string supplier;
        private string manuDate; 
        private string price;
        private string active;
        private string quntity;
        private string quntityInstock;

        public string InventoryID
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsLegalDigit(value)&&int.Parse(value)>0&&value!="")
                    this.inventoryID = value;
                else 
                  throw new Exception("incorrect");
                
            }
            get
            {
                return this.inventoryID;

            }
        }
        public string MotorID
        {
            set
            {
                if (int.Parse(value)>0)
                  this.motorID = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.motorID;

            }
        }
        public string Supplier
        {
            set
            {
                if (value!="")
                  this.supplier = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.supplier;

            }
        }
        public string ManuDate
        {
            set
            {
                if (value != "")
                    this.manuDate = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.manuDate;

            }
        }
        public string Price
        {
            set
            {
                if (int.Parse(value)>0&&UTILITIES.ValidationsUtilities.IsLegalDigit(value))
                    this.price = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.price;

            }
        }
        public string Active
        {
            set
            {
                if (value == "כן"|| value == "לא")
                    this.active = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.active;

            }
        }
        
        public string Quntity
        {
            set
            {
                if (int.Parse(value) > 0 && UTILITIES.ValidationsUtilities.IsLegalDigit(value))
                    this.quntity = value;
                else
                  throw new Exception(" enter fault description of the motor");
                
            }
            get
            {
                return this.quntity;

            }
        }
        public string QuntityInstock
        {
            set
            {
                if (int.Parse(value) > 0 && UTILITIES.ValidationsUtilities.IsLegalDigit(value))
                    this.quntityInstock = value;
                else 
                  throw new Exception(" enter possible causes of the motor");
                
            }
            get
            {
                return this.quntityInstock;

            }
        }
        


    }
}
