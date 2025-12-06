using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Factory
    {

        private string companyNumber;
        private string factoryName;
        private string daysForPayments;
        private string phoneNumber;
        private string representativeName;
        private string representativePhoneNumber;
        private string mail;
        private string maintainManegerName;
        private string maintainManegerPhoneNumber;
        public string CompanyNumber
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter correct compay number");
                this.companyNumber = value;
            }
            get
            {
                return this.companyNumber;

            }
        }
        public string FactoryName
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter correct factory name");
                this.factoryName = value;
            }
            get
            {
                return this.factoryName;

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
        public string DaysForPayments
        {
            set
            {
                if (int.Parse(value) < 0)
                    throw new Exception(" enter correct factory name");
                this.daysForPayments = value;
            }
            get
            {
                return this.daysForPayments;

            }
        }
        public string RepresentativeName
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter representative name");
                this.representativeName = value;
            }
            get
            {
                return this.representativeName;

            }
        }
        public string RepresentativePhoneNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsPhoneNum(value))
                    throw new Exception(" enter representative's phone number");
                this.representativePhoneNumber = value;
            }
            get
            {
                return this.representativePhoneNumber;

            }
        }  
            public string Mail
            {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsMail(value))
                    throw new Exception(" enter representative's phone number");
                this.mail = value;
            }
            get
            {
                return this.mail;

            }
        }
        public string MaintainManegerName
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter maintain maneger's name");
                this.maintainManegerName = value;
            }
            get
            {
                return this.maintainManegerName;

            }
        }
        public string MaintainManegerPhoneNumber
        {
            set
            {
                if (UTILITIES.ValidationsUtilities.IsPhoneNum(value))
                    throw new Exception(" enter maintain maneger's phone number");
                this.maintainManegerPhoneNumber = value;
            }
            get
            {
                return this.maintainManegerPhoneNumber;

            }
        }
    }
}

