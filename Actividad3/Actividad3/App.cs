using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Hello, Forms!",
					TextColor= Color.Aqua,
					VerticalOptions = LayoutOptions.EndAndExpand,
					HorizontalOptions = LayoutOptions.StartAndExpand,
				},
			};
		}
	}
}

