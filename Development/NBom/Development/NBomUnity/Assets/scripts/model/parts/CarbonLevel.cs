using UnityEngine;
using System.Collections;
using GameUtil2D;

public class CarbonLevel : MonoBehaviour
{
		public Cap level = new Cap(0, 1);

		// The higher the carbon rating, the slower the ship and the less drag.

		void Update ()
		{
			gameObject.rigidbody2D.drag = GetDrag ();
			gameObject.GetComponent<Thruster> ().power = GetPower ();			
		}

		private float GetPower(){
			return 200f - (level.value * 100f);
		}

		private float GetDrag(){
			return 6.0f - (level.value * 3f);
		}
}

