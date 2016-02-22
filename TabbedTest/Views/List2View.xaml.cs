using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedTest
{
	public partial class List2View : ContentPage
	{
		public List2View ()
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
			list2.ItemsSource = items;
		}
	}
}

