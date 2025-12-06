using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    
    
    class Repairing
    {
        
        private string motorSerialNumber;
        private string status;
        private string motorId;
        private string faultDescription;
        private string repairingDescription;
        private string possibleCauses;
        private string warranty;
        private string history;
        private string beginingDate;
        private string endDate;


        public string MotorSerialNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsLegalDigit(value)&&value!=""&&int.Parse(value)>0)
                    this.motorSerialNumber = value;
                else
                    throw new Exception(" enter correct serial number");
                
            }
            get
            {
                return this.motorSerialNumber;

            }
        }
        public string Status
        {
            set
            {
                if (value!="")
                    this.status = value;
                else
                    throw new Exception("incorrect");
                
            }
            get
            {
                return this.status;

            }
        }
        public string MotorId
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsLegalDigit(value)&&int.Parse(value)>0)
                    this.motorId = value;
                else
                   throw new Exception(" enter correct motor ID");
                
            }
            get
            {
                return this.motorId;

            }
        }
        public string FaultDescription
        {
            set
            {
                if (value!="")
                    this.faultDescription = value;
                else
                   throw new Exception(" enter correct fault description");
                
            }
            get
            {
                return this.faultDescription;

            }
        }
        public string RepairingDescription
        {
            set
            {
                if (value != "")
                    this.repairingDescription = value;
                else
                    throw new Exception(" enter correct repairing description");
                
            }
            get
            {
                return this.repairingDescription;

            }
        }
        public string PossibleCauses
        {
            set
            {
                if (value != "")
                    this.possibleCauses = value;
                else
                  throw new Exception(" enter correct possible causes");
                
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
                if (value == "כן"|| value == "לא")
                    this.warranty = value;
                else
                    throw new Exception(" enter correct warranty format");
                
            }
            get
            {
                return this.warranty;

            }
        }
        public string History
        {
            set
            {
                if (value != "")
                    this.history = value;
                else
                    throw new Exception(" enter correct history format");
                 
            }
            get
            {
                return this.history;

            }
        }
        public string BeginingDate
        {
            set
            {
                if (value != "")
                    this.beginingDate = value;
                else
                    throw new Exception("incorrect");

            }
            get
            {
                return this.beginingDate;

            }
        }
        public string EndDate
        {
            set
            {
                if (value != "")
                    this.endDate = value;
                else
                    throw new Exception("incorrect");

            }
            get
            {
                return this.endDate;

            }
        }

    }
}
