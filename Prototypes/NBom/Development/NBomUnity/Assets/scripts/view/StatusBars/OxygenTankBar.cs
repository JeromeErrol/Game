using UnityEngine;
using System.Collections;
using GameUtil2D;

public class OxygenTankBar : StatusBar
{
		void Start ()
		{
			cap = GetComponent<OxygenTank>().oxygen;
		}
}

