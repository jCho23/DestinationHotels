using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace DestinationHotels

{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void ReplTest()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{ 
			app.Tap("Destination Hotels");
			app.Screenshot("Tapped on 'Destination Hotels'");

			app.Tap("Exclusive Offers");
			app.Screenshot("Tapped on Exclusive Offers");

			app.Tap("Destination Dream List");
			app.WaitForElement(x => x.Css(".navigation--booknow"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Destination Dream List'");

			app.Back();
			app.Screenshot("Pressed back to get to 'Exclusive Offers' page");

			app.Tap("Destination Family Escapes");
			Thread.Sleep(2000);
			app.Screenshot("Tapped on Destination Family Escapes");

			app.Back();
			app.Screenshot("Pressed back to get to 'Exclusive Offers' page");

			app.Tap("Other Offers");
			app.WaitForElement(x => x.Css(".navigation--booknow"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Other Offers'");

			app.Back();
			app.Screenshot("Pressed back to get to 'Exclusive Offers' page");

			app.Tap("Make Reservation");
			app.Screenshot("Tapped on Reservation Button");

			app.WaitForElement(x => x.Css(".navigation--booknow"));
			app.Tap(x => x.Css(".navigation--booknow"));
			app.Screenshot("Tapped on 'Book Now'");
			   

		}




	}
}
