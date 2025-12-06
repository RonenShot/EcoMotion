using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Inventory
    {
        private string motorSerialNumber;
        private string motorID;
        private string status;
        private string supplier;
        private string history;
        private string receivingDate;
        private string faultDescription;
        private string possibleCauses;
        private string warranty;
        private string price;
        private string exist;
        public string MotorSerialNumber
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter serial number");
                this.motorSerialNumber = value;
            }
            get
            {
                return this.motorSerialNumber;

            }
        }
        public string MotorID
        {
            set
            {
                if (int.Parse(value)>0)
                    throw new Exception(" enter correct motor id");
                this.motorID = value;
            }
            get
            {
                return this.motorID;

            }
        }
        public string Status
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter status");
                this.status = value;
            }
            get
            {
                return this.status;

            }
        }
        public string Supplier
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter supplier");
                this.supplier = value;
            }
            get
            {
                return this.supplier;

            }
        }
        public string History
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter history of the motor");
                this.history = value;
            }
            get
            {
                return this.history;

            }
        }
        public string ReceivingDate
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter history of the motor");
                this.receivingDate = value;
            }
            get
            {
                return this.receivingDate;

            }
        }
        
        public string FaultDescription
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter fault description of the motor");
                this.faultDescription = value;
            }
            get
            {
                return this.faultDescription;

            }
        }
        public string PossibleCauses
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter possible causes of the motor");
                this.possibleCauses = value;
            }
            get
            {
                return this.possibleCauses;

            }
        }
        public string Warranty
        {
            set
            {
                if (value != "yes"||value!="no"||value!="כן"||value!="לא")
                    throw new Exception(" enter if the motor include in warranty");
                this.warranty = value;
            }
            get
            {
                return this.warranty;

            }
        }
        public string Price
        {
            set
            {
                if (double.Parse(value)<0)
                    throw new Exception(" enter correct price");
                this.price = value;
            }
            get
            {
                return this.price;

            }
        }
        public string Exist
        {
            set
            {
                if (value =="")
                    throw new Exception(" enter if the motor exist in inventory");
                this.exist = value;
            }
            get
            {
                return this.exist;

            }
        }


    }
}
