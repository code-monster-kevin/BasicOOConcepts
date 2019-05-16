namespace BasicOOConcepts.Model.Classification
{
    public enum TransportationMode
    {
        LAND,
        SEA,
        AIR
    }
    public class Vehicle
    {
        public int ID { get; set; }
        public string VehicleType { get; set; }
        public int TopSpeedKM { get; set; }
        public int MaxSeating { get; set; }

        public TransportationMode TransportMode { get; set; }
    }
}