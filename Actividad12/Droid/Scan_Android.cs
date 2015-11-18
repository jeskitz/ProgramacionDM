using System;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency (typeof (Actividad12.Droid.Scan_Android))]
namespace Actividad12.Droid
{

	public class Scan_Android: IScan
	{
		public Scan_Android ()
		{
		}

		//Implementamos el metodo Scan definido en la interfaz IScan
		public async System.Threading.Tasks.Task<String> Scan(){

			var ctx = Forms.Context;

			var options = new ZXing.Mobile.MobileBarcodeScanningOptions();
			options.PossibleFormats = new System.Collections.Generic.List<ZXing.BarcodeFormat>()
			{
				ZXing.BarcodeFormat.QR_CODE,
			};

			var scanner = new ZXing.Mobile.MobileBarcodeScanner(ctx);
			var result = await scanner.Scan(options);

			if(result != null)
				return result.ToString ();

			return string.Empty;
		} 
	}
}

