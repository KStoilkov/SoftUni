namespace _02.Laptops
{
    using System;

    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string batteryType, double batteryLife)
            : this(batteryType)
        {
            this.BatteryLife = batteryLife;
        }

        public string BatteryType 
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public double BatteryLife 
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Life cannot be less than 0.");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Battery: {0}\nBattery life: {1} hours", 
                this.batteryType, this.batteryLife);
        }
    }
}
