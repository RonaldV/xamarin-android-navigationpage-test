using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedTest
{
	public partial class List1cView : ContentPage
	{
		public List1cView ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			System.Diagnostics.Debug.WriteLine ("{0}: {1}", DateTime.Now.ToString ("s"), "List 1 c");
		
			base.OnAppearing ();

			var items = new List<TestModel> {
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
				new TestModel { Name = "Test", Description = "Description" },
			};
			list1c.ItemsSource = items;
		}
	}
}

