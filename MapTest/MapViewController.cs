using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;

namespace MapTest
{
	partial class MapViewController : UIViewController
	{
		private MKMapView map;
		private CLLocationManager locationManager = new CLLocationManager();

		public MapViewController(IntPtr handle) : base(handle)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			map = new MKMapView(View.Bounds);
			map.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
			map.MapType = MKMapType.Standard;
			View.AddSubview(map);

			double latitude = 52.053518;
			double longitude = -2.718113;

			var target = new CLLocationCoordinate2D(latitude, longitude);
			var zoomRegion = MKCoordinateRegion.FromDistance(target, 2000, 2000);

			map.CenterCoordinate = target;
			map.Region = zoomRegion;
			map.Delegate = new MapDelegate();

			locationManager.RequestWhenInUseAuthorization();
			map.ShowsUserLocation = true;
			map.AddAnnotation(new MKPointAnnotation()
			{
				Title = "TestTime!",
				Coordinate = new CLLocationCoordinate2D(latitude, longitude)
			});

		}
	}
}