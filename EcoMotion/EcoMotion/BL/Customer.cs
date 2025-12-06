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


        public string PhoneNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsPhoneNum(value))
                    this.phoneNumber = value;
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
                if (value != " ")
                    this.cFirstName = value;
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
                if (value != " ")
                    this.cLastName = value;
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
                if (value != " ")
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
                if (value != " ")
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
                if (value != " ")
                    this.houseNumber = value;
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
            }
            get
            {
                return this.mail;

            }

        }


    }
}
    
