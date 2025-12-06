using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Customer
    {
        private string id;
        private string cFirstName;
        private string cLastName;
        private string citiy;
        private string phoneNumber;
        private string street;
        private string houseNumber;
        private string mail;
        private string company;
        private string active;

        public string Id
        {
            set
            {
                if ((value != "") && (UTILITIES.ValidationsUtilities.LegalId(value)))
                    this.id = value; 
                else 
                   throw new Exception("incorrect");
                
            }
            get
            {
                return this.id;

            }
        }


        public string PhoneNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsPhoneNum(value))
                    this.phoneNumber = value; 
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.phoneNumber;

            }

        }
        public string CFirstName
        {
            set
            {
                if (value != "")
                    this.cFirstName = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.cFirstName;

            }

        }
        public string CLastName
        {
            set
            {
                if (value != "")
                    this.cLastName = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.cLastName;

            }

        }
        public string Citiy
        {
            set
            {
                if (value != "")
                    this.citiy = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.citiy;

            }

        }
        public string Street
        {
            set
            {
                if (value != "")
                    this.street = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.street;

            }

        }
        public string HouseNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsLegalDigit(value)&& value!="")
                    this.houseNumber = value; 
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.houseNumber;

            }

        }
        public string Mail
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsMail(value))
                    this.mail = value; 
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.mail;

            }

        }
        public string Company
        {
            set
            {
                if (value!="")
                    this.company = value;
                else
                    throw new Exception("incorrect");
            }
            get
            {
                return this.company;

            }

        }
        public string Active
        {
            set
            {
                if (value == "כן" || value == "לא")
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
    
