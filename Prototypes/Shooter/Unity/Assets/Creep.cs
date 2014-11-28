using UnityEngine;
using System.Collections;

public class Creep : UserInteractive
{
		void FixedUpdate(){

		}

		public override void Pressed ()
		{
				Destroy (gameObject);
		}
}

