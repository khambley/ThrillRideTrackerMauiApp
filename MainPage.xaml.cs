using ThrillRideTrackerMauiApp.Models;
using ThrillRideTrackerMauiApp.Pages;

namespace ThrillRideTrackerMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        var items = new List<MyRide>
            {
                new MyRide
                {
                    RideName = "Raging Bull",
                    RideType = "Roller Coaster",
                    Height = 208,
                    TopSpeed = 45,
                    BuildDate = Convert.ToDateTime("01/01/1999"),
                    WebLink = "https://www.sixflags.com/greatamerica/attractions/raging-bull",
                    DateAdded = DateTime.Today,
                    RideDate = DateTime.Now,
                    ParkName = "Six Flags Great America",
                    City = "Gurnee",
                    State = "IL",
                    Latitude = 42.3707,
                    Longitude = -87.9359,
                    RiderName = "Katherine",
                    Rating = 5.0M,
                    Comments = "Never gets old",
                    IsFirstRide = false

                },
                new MyRide
                {
                    RideName = "Goliath",
                    RideType = "Roller Coaster",
                    Height = 165,
                    TopSpeed = 72,
                    BuildDate = Convert.ToDateTime("01/01/2014"),
                    WebLink = "https://www.sixflags.com/greatamerica/attractions/goliath",
                    DateAdded = DateTime.Today,
                    RideDate = DateTime.Now,
                    ParkName = "Six Flags Great America",
                    City = "Gurnee",
                    State = "IL",
                    Latitude = 42.3707,
                    Longitude = -87.9359,
                    RiderName = "Katherine",
                    Rating = 4.5M,
                    Comments = "A tight squeeze but overall fun.",
                    IsFirstRide = false

                },
                new MyRide
                {
                    RideName = "Millenium Force",
                    RideType = "Roller Coaster",
                    Height = 310,
                    TopSpeed = 93,
                    BuildDate = Convert.ToDateTime("01/01/2000"),
                    WebLink = "https://www.cedarpoint.com/rides-experiences/millennium-force",
                    DateAdded = DateTime.Today,
                    RideDate = DateTime.Now,
                    ParkName = "Cedar Point",
                    City = "Sandusky",
                    State = "OH",
                    Latitude = 41.48231138659273,
                    Longitude = -82.6834884320427,
                    RiderName = "Conner",
                    Rating = 4.75M,
                    Comments = "I pooped my pants.",
                    IsFirstRide = true
                }
            };
        rides.ItemsSource = items;
    }

    void New_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new NewEntryPage());
    }

}


