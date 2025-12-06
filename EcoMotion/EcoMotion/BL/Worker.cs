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
        public string Id
        {
            set
            {
                if ((value == " ") && (UTILITIES.ValidationsUtilities.LegalId(value)))
                    throw new Exception(" enter correct id");
                this.id = value;
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
                if (value=="")
                    throw new Exception(" enter first name");
                this.firstName = value;
            }
            get
            {
                return this.firstName;

            }
        }
        public string LirstName
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter last name");
                this.lastName = value;
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
                if (value == "")
                    throw new Exception(" enter citiy");
                this.citiy = value;
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
                if (value == "")
                    throw new Exception(" enter street");
                this.street = value;
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
                if (int.Parse(value) <0)
                    throw new Exception(" enter house number");
                this.houseNumber = value;
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
                    throw new Exception(" enter correct phone number");
                this.phoneNumber = value;
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
                    throw new Exception(" enter mail");
                this.mail = value;
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
                if (value=="")
                    throw new Exception(" enter work start date");
                this.startDate = value;
            }
            get
            {
                return this.startDate;

            }
        }




    }
}
