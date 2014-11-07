using UnityEngine;
using System.Collections;

public class AlphaChange : MonoBehaviour
{
		public float amount;

	
		void Update ()
		{
				gameObject.ModifyAlpha (amount);
		}
}

