using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Menu: ContentPage
	{
		public Menu ()
		{
			Button boton1 = new Button
			{
				Text = "Empleados"
			};

			boton1.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Empleados());
			};

			Button boton2 = new Button
			{
				Text = "Mis datos"
			};

			boton2.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new MisDatos());
			};
			Button boton3 = new Button
			{
				Text = "Noticias"
			};

			boton3.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Noticias());
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					boton1,
					boton2,
					boton3
				}
				};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}
