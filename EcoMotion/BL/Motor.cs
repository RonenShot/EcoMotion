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
                if(int.Parse(value)>0)
                    this.motorID = value;
                else
                  throw new Exception("incorrect");
                
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
                if (value!="")
                    this.electricalConnectionType = value;
                else 
                  throw new Exception("incorrect");
                
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
                if (value == "ac"||value=="AC"||value=="dc"||value=="DC")
                    this.voltageType = value;
                else 
                  throw new Exception("incorrect");
                
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
                if (int.Parse(value)>0)
                    this.rpm = value;
                else 
                  throw new Exception("incorrect");
                
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
                if (int.Parse(value) > 0)
                    this.hp = value;
                else 
                  throw new Exception("incorrect");
                
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
                if (value!="")
                    this.productionLand = value;
                else
                   throw new Exception("incorrect");
                
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
                if (int.Parse(value)>0||int.Parse(value)%3==0)
                    this.numberOfSlots = value;
                else 
                   throw new Exception("incorrect");
                
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
                if (double.Parse(value)<=100||double.Parse(value)>0)
                    this.efficiency = value;
                else 
                  throw new Exception("incorrect");
                
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
                if (value!="")
                    this.structreType = value;
                else
                   throw new Exception("incorrect");
                
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
                if (value != "")
                    this.manufacturer = value;
                else
                   throw new Exception("incorrect");
                
            }
            get
            {
                return this.manufacturer;

            }

        }








    }
}

