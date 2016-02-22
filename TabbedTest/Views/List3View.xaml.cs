using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedTest
{
	public partial class List3View : ContentPage
	{
		public List3View ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			var items = new List<TestModel> {
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
			};
			list3.ItemsSource = items;
		}
	}
}

