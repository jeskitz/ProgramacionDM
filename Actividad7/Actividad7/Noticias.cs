using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Noticias: ContentPage
	{
		public Noticias ()
		{
				var listView = new ListView {
					RowHeight = 50
				};

				String[] arreglo = new string [] {
					"México",
					"Estados Unidos",
					"América Latina",
					"Europa",
					"Asia"
				};

			Button boton = new Button
			{
				Text = "Volver al menú"
			};

			boton.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Menu());
			};

			listView.ItemsSource = arreglo;
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Start,
				Children = 
				{ listView,
					boton
				}
			};
		}
	}
}