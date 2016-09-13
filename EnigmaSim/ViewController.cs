using System;
using System.Linq;

using UIKit;
using GTSoft.EnigmaSim.Model;
using GTSoft.EnigmaSim.EnigmaEngine;

namespace EnigmaSim
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		private static GTSoft.EnigmaSim.Components.Rotor.BaseRotor Rotor(string name, GTSoft.EnigmaSim.Model.IEnigma engine)
		{
			var rotor = (from r in engine.Rotors
						 where r.Name == name
						 select r).First();
			return rotor;
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnEncode.TouchUpInside += (sender, e) =>
			{

				txtPlainText.ResignFirstResponder();

				string fastRotorName = "Rotor III";
				string middleRotorName = "Rotor II";
				string slowRotorName = "Rotor I";
				string reflectorName = "reflector B";
				IEnigma target = new Basic3Wheel(fastRotorName, middleRotorName, slowRotorName, reflectorName);

				Rotor(fastRotorName, target).SetWheelOffset('K');
				Rotor(middleRotorName, target).SetWheelOffset('C');
				Rotor(slowRotorName, target).SetWheelOffset('N');

				//char result = target.DecipherCharacter('E');
				string rawText = this.txtPlainText.Text.ToUpper();
				string result = target.DecipherString(rawText);
				this.txtEncodedText.Text = result;

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

