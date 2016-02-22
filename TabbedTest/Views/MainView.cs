using System;

using Xamarin.Forms;

namespace TabbedTest
{
	public class MainView : TabbedPage
	{
		public MainView ()
		{
			Children.Add (WrapInNavigationPage (new List1View (), "Test 1"));
			Children.Add (WrapInNavigationPage (new List2View (), "Test 2"));
			Children.Add (WrapInNavigationPage (new List3View (), "Test 3"));
		}

		public static NavigationPage WrapInNavigationPage (Page page, string title = null)
		{
			return new NavigationPage (page) {
				Title = title
			};
		}
	}
}


