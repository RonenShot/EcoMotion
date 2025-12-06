using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMotion.BL
{
    class Motor
    {
        private string motorID;
        private string electricalConnectionType;
        private string voltageType;
        private string rpm;
        private string hp;
        private string productionLand;
        private string numberOfSlots;
        private string efficiency;
        private string structreType;
        private string manufacturer;

        public string  MotorID
        {
            set
            {
                if(int.Parse(value)<0)
                    throw new Exception(" enter correct motor id");
                this.motorID = value;
            }
            get
            {
                return this.motorID;

            }
        }
        public string ElectricalConnectionType
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter electrical connection type");
                this.electricalConnectionType = value;
            }
            get
            {
                return this.electricalConnectionType;

            }
        } 
        public string VoltageType
        {
            set
            {
                if (value != "ac"||value!="AC"||value!="dc"||value!="DC")
                    throw new Exception("enter correct voltage type");
                this.voltageType = value;
            }
            get
            {
                return this.voltageType;

            }

        } 
        public string Rpm
        {
            set
            {
                if (int.Parse(value)<0)
                    throw new Exception(" enter correct RPM");
                this.rpm = value;
            }
            get
            {
                return this.rpm;

            }

        }
        public string Hp
        {
            set
            {
                if (int.Parse(value) < 0)
                    throw new Exception(" enter correct HP");
                this.hp = value;
            }
            get
            {
                return this.hp;

            }

        }
        public string ProductionLand
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter productionLand");
                this.productionLand = value;
            }
            get
            {
                return this.productionLand;

            }

        }
        public string NumberOfSlots
        {
            set
            {
                if (int.Parse(value)<0||int.Parse(value)%3!=0)
                    throw new Exception(" enter correct number of slots");
                this.numberOfSlots = value;
            }
            get
            {
                return this.numberOfSlots;

            }

        }
        public string Efficiency
        {
            set
            {
                if (double.Parse(value)>=100||double.Parse(value)<0)
                    throw new Exception(" enter correct efficiency");
                this.efficiency = value;
            }
            get
            {
                return this.efficiency;

            }

        }
        public string StructreType
        {
            set
            {
                if (value=="")
                    throw new Exception(" enter Structre Type");
                this.structreType = value;
            }
            get
            {
                return this.structreType;

            }

        }
        public string Manufacturer
        {
            set
            {
                if (value == "")
                    throw new Exception(" enter Manufacturer");
                this.manufacturer = value;
            }
            get
            {
                return this.manufacturer;

            }

        }








    }
}

