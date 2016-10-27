using System;
using MapKit;
using CoreLocation;

namespace MapTest
{
	public class MapAnnotation : MKAnnotation
	{
		public MapAnnotation()
		{
		}

		private string title;
		CLLocationCoordinate2D coordinate;

		public MapAnnotation(string title, CLLocationCoordinate2D coordinate)
		{
			this.title = title;
			this.coordinate = coordinate;
		}

		public override string Title
		{
			get
			{
				return title;
			}
		}

		public override CLLocationCoordinate2D Coordinate
		{
			get
			{
				return coordinate;
			}
		}
	}
}