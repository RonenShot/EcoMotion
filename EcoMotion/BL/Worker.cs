using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Worker
    {
        private string id;
        private string firstName;
        private string lastName;
        private string citiy;
        private string street;
        private string houseNumber;
        private string phoneNumber;
        private string mail;
        private string startDate;
        private string active;
        public string Id
        {
            set
            {
                if ((value != "") && (UTILITIES.ValidationsUtilities.LegalId(value)))
                    this.id = value;
                else 
                    throw new Exception(" enter correct id");
                
            }
            get
            {
                return this.id;

            }
        }
        public string FirstName
        {
            set
            {
                if (value!="")
                    this.firstName = value;
                else
                    throw new Exception(" enter first name");
                
            }
            get
            {
                return this.firstName;

            }
        }
        public string LastName
        {
            set
            {
                if (value != "")
                    this.lastName = value;
                else
                    throw new Exception(" enter last name");
                
            }
            get
            {
                return this.lastName;

            }
        }
        public string Citiy
        {
            set
            {
                if (value != "")
                    this.citiy = value;
                else
                    throw new Exception(" enter citiy");
                
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
                    throw new Exception(" enter street");
                
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
                if (int.Parse(value) >0&&UTILITIES.ValidationsUtilities.IsLegalDigit(value))
                    this.houseNumber = value;
                else
                    throw new Exception(" enter house number");
                
            }
            get
            {
                return this.houseNumber;

            }
        }
        public string PhoneNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsPhoneNum(value))
                    this.phoneNumber = value;
                else
                    throw new Exception(" enter correct phone number");
                
            }
            get
            {
                return this.phoneNumber;

            }
        }
        public string Mail
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsMail(value))
                    this.mail = value;
                else
                    throw new Exception(" enter mail");
                
            }
            get
            {
                return this.mail;

            }
        }
        public string StartDate
        {
            set
            {
                if (value!="")
                    this.startDate = value;
                else
                    throw new Exception(" enter work start date");
                
            }
            get
            {
                return this.startDate;

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
