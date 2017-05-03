using System;
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
		public void FirstTest()
		{
			app.Tap("up");
			app.Screenshot("Let's start by Tapping on the Hamburger Icon");
			app.Tap("Top Stories");
			app.Screenshot("Then we Tapped on 'Top Stories'");

			app.Tap("up");
			app.Screenshot("We Tapped on the Hamburger Icon");
			app.Tap("Local News");
			app.Screenshot("Next we Tapped 'Local News'");

			app.ScrollDown();

		}

	}
}
