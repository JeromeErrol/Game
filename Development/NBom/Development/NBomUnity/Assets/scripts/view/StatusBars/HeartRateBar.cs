using UnityEngine;
using System.Collections;
using GameUtil2D;

public class HeartRateBar : StatusBar
{

		void Start ()
		{
			cap = gameObject.GetComponent<HeartRate> ().level;
		}

		
}

