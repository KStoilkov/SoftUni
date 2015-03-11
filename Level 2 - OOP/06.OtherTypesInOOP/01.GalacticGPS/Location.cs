namespace _01.GalacticGPS
{
    public struct Location
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format(this.Latitude + ", " + this.Longitude + " - " + this.Planet);
        }
    }
}
