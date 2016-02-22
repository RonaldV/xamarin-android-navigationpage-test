using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace TabbedTest
{
	public partial class List1aView : ContentPage
	{
		public List1aView ()
		{
			InitializeComponent ();
		}

		List<TestModel> GetItems ()
		{
			var items = new List<TestModel> {
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
				new TestModel {
					Name = "Test",
					Description = "Description"
				},
			};
			return items;
		}

		protected override void OnAppearing ()
		{
			System.Diagnostics.Debug.WriteLine ("{0}: {1}", DateTime.Now.ToString ("s"), "List 1 a");

			base.OnAppearing ();

			list1a.ItemsSource = GetItems ();
			list1a.ItemSelected += List1_ItemSelected;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			list1a.ItemSelected -= List1_ItemSelected;
		}

		void List1_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync (new List1bView ());
		}
	}
}

