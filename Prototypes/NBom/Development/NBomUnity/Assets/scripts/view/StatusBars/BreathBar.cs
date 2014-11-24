using UnityEngine;
using System.Collections;
using GameUtil2D;

public class BreathBar : StatusBar
{
		
		void Start ()
		{
			cap = GetComponent<Breath> ().oxygen;
		}	
}

