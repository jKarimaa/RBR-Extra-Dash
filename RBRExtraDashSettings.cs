namespace RBRExtraDash
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class RBRExtraDashSettings
    {
        private double trip = 0.0;

        public void SetTrip(double newTrip)
        {
            trip = newTrip;
        }

        public double GetTrip()
        {
            return trip;
        }

        public void ResetTrip()
        {
            trip = 0.0;
        }
    }
}