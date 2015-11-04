using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Actividad11
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			//El control ListView muestra el contenido en forma de tabla 
			//Con RowHeight le indicamos el alto de cada renglón
			var listView = new ListView
			{
				RowHeight = 40
			};

			//Le indicamos al ListView de donde tomar los datos
			listView.ItemsSource = ObtenListaFrutas();
			//Le indicamos al listview que plantilla utilizar
			listView.ItemTemplate = new DataTemplate(typeof(FrutasCell));

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}

		public List<Frutas> ObtenListaFrutas()
		{
			var lista = new List<Frutas> ();

			lista.Add (new Frutas{Nombre = "Platano", Imagen = "http://www.clipartbest.com/cliparts/9ip/eMB/9ipeMBg7T.png"});
			lista.Add (new Frutas{Nombre = "Pina", Imagen = "http://malaganaturalbio.com/WebRoot/Store8/Shops/a6cb0002-e2ba-4648-acde-ba2439c30312/5495/4B96/0C17/AC4A/EC2B/0A48/3521/E81A/PINA.png"});
			lista.Add (new Frutas{ Nombre = "Fresa", Imagen = "http://lh5.ggpht.com/-PT8Z9jyP2MA/Ubj-6nYxIcI/AAAAAAAAEhU/DqQAScJqjWo/s9000/01.png" });
			lista.Add (new Frutas{Nombre = "Sandia", Imagen = "http://3vimir3l0i0322tm4k1i9ks4.wpengine.netdna-cdn.com/wp-content/uploads/2012/06/Leopard.png"});
			lista.Add (new Frutas{Nombre = "Kiwi", Imagen = "http://icons.iconseeker.com/png/fullsize/new-zealand-icons/kiwi-fruit.png"});
			return lista;
		}
	}
}

