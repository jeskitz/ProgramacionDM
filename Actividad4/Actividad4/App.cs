using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			/*Se crea un objeto etiqueta
			Label label = new Label();

			//Se modifican sus propiedades
			//Texto
			label.Text = "Cámbiame";
			//Color del texto
			label.TextColor = Color.Blue;
			//Alineación vertical (YAlign). Para la alineación horizontal, usar XAlign
			label.YAlign = TextAlignment.Center;

		//Label label = new Label{ Text = "Cámbiame", TextColor =  Color.Blue, YAlign = TextAlignment.Center };

			//Se crea una página y se le asigna como contenido la etiqueta que se creó
			ContentPage contentPage = new ContentPage();
			contentPage.Content = label;

			return contentPage;
		}

		*/

		//El mismo código usando inicializador de objetos
			return new ContentPage {
				label = new Label {
					Text = "Cámbiame",
					TextColor = Color.Blue,
					VerticalOptions = TextAlignment.Center,
				},

			};
		
		}
	}
}