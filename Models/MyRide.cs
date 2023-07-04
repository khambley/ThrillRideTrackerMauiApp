using System;
namespace ThrillRideTrackerMauiApp.Models
{
	public class MyRide
	{
        public int Id { get; set; }
        public string RideName { get; set; }
        public string RideType { get; set; }
        public string RiderName { get; set; }
        public int Height { get; set; }
        public int TopSpeed { get; set; }
        public DateTime BuildDate { get; set; }
        public string WebLink { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime RideDate { get; set; }

        public string ParkName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public decimal Rating { get; set; }
        public string Comments { get; set; }

        public string Description { get; set; }
        public string Notes { get; set; }
        public string ImageFilename { get; set; }
        public bool IsFirstRide { get; set; }
    }
}

