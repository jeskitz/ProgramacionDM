﻿using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Empleados: ContentPage
	{
		public Empleados ()
		{
			var listView = new ListView {
				RowHeight = 50
			};

			String[] arreglo = new string [] {
				"Jessica Itzel Rodríguez López",
				"Marco Francisco Arellano Frausto",
				"Mónica Gabriela Rodríguez López",
				"Sofía Rivera Rodríguez"
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
			