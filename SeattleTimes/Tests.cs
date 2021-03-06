﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace SeattleTimes
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
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void HamburgerIconTest()
		{
			Thread.Sleep(8000);
			app.Tap("up");
			app.Screenshot("Let's start by Tapping on the Hamburger Icon");
			Thread.Sleep(4000);
			app.Tap("Top Stories");
			app.Screenshot("Then we Tapped on 'Top Stories'");

			app.Tap("up");
			app.Screenshot("We Tapped on the Hamburger Icon");
			Thread.Sleep(4000);
			app.Tap("Local News");
			app.Screenshot("Next we Tapped 'Local News'");

			app.ScrollDown();
			app.Screenshot("We Scrolled Down for more information");
			Thread.Sleep(4000);

			app.Tap("action_refresh");
			app.Screenshot("Then we Tapped the 'Refresh' Button");
		}

	}
}
