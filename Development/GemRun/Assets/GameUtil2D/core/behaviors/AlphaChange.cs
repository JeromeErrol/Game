using UnityEngine;
using System.Collections;

public class AlphaChange : MonoBehaviour
{
		public float amount;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				gameObject.ModifyAlpha (amount);
		}
}
