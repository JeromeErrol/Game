using UnityEngine;
using System.Collections;

public class ExitButton : UIComponent
{
		public override void Clicked ()
		{
				GameFSM.Exit ();
		}

		public override void Pressed ()
		{
				throw new System.NotImplementedException ();
		}
}

