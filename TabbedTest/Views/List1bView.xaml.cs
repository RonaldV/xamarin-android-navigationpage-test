using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace TabbedTest
{
	public partial class List1bView : ContentPage
	{
		public List1bView ()
		{
			InitializeComponent ();
		}
		//
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
		//			list1b.ItemsSource = await GetItems ();
		//			list1b.ItemSelected += List1_ItemSelected;
		//		}
		//

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
			System.Diagnostics.Debug.WriteLine ("{0}: {1}", DateTime.Now.ToString ("s"), "List 1 b");

			base.OnAppearing ();

			list1b.ItemsSource = GetItems ();
			list1b.ItemSelected += List1_ItemSelected;
		}


		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			list1b.ItemSelected -= List1_ItemSelected;
		}

		void List1_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync (new List1cView ());
		}
	}
}

