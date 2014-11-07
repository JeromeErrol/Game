using UnityEngine;
using System.Collections;

public class DestroyOnClick : UserInteractive
{

		public override void Pressed ()
		{
				GameObject.Destroy (gameObject);
		}
}

