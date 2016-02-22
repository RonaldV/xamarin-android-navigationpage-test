using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace TabbedTest
{
	public partial class List1View : ContentPage
	{
		public List1View ()
		{
			InitializeComponent ();
		}

		//		async Task<List<TestModel>> GetItems ()
		//		{
		//			var items = new List<TestModel> {
		//				new TestModel {
		//					Name = "Test",
		//					Description = "Description"
		//				},
		//				new TestModel {
		//					Name = "Test",
		//					Description = "Description"
		//				},
		//				new TestModel {
		//					Name = "Test",
		//					Description = "Description"
		//				},
		//			};
		//			return items;
		//		}
		//
		//		protected async override void OnAppearing ()
		//		{
		//			base.OnAppearing ();
		//
		//			list1.ItemsSource = await GetItems ();
		//			list1.ItemSelected += List1_ItemSelected;
		//		}

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
			};
			return items;
		}

		protected  override void OnAppearing ()
		{
			System.Diagnostics.Debug.WriteLine ("{0}: {1}", DateTime.Now.ToString ("s"), "List 1");

			base.OnAppearing ();

			list1.ItemsSource = GetItems ();
			list1.ItemSelected += List1_ItemSelected;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			list1.ItemSelected -= List1_ItemSelected;
		}

		void List1_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync (new List1aView ());
		}

		//		async void List1_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		//		{
		//			await Navigation.PushAsync (new List1aView ());
		//		}
	}
}

