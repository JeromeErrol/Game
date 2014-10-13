using UnityEngine;
using System.Collections;
using GameUtil2D;

public class CarbonBar : StatusBar
{
		void Start ()
		{			
			cap = gameObject.GetComponent<CarbonLevel> ().level;
		}

		void Update(){
			//this.textValue = gameObject.GetComponent<CarbonLevel> ().level.value.ToString();
		}
}

