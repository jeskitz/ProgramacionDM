using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class MisDatos: ContentPage
	{
		public MisDatos ()
		{
			var listView = new ListView {
				RowHeight = 50
			};

			String[] arreglo = new string [] {
				"Jessica Itzel Rodríguez López",
				"Facultad de Contaduría y Administración",
				"Licenciatura en Informática",
				"Sexto semestre",
				"Programación de dispositivos móviles"
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
