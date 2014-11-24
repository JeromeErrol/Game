using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Breath : MonoBehaviour
{		
		public Cap oxygen = new Cap (0, 1);
		int currentAction = 0;
		int IN = 0;
		int OUT = 1;

		void Start ()
		{
			
		}
	
		void Update ()
		{
				if (currentAction == IN) {
						BreathIn ();
				} else if (currentAction == OUT) {
						BreathOut ();
				}

				if (currentAction == IN && oxygen.IsMaxed) {
						currentAction = OUT;
				} else if (currentAction == OUT && oxygen.IsZero) {
						currentAction = IN;
				}
		}

		public void BreathIn ()
		{
				OxygenTank oxygenTank = GetComponent<OxygenTank> (); 	
				if (oxygenTank.oxygen.IsNotZero) {								
						oxygenTank.oxygen.value -= 0.0002f;			
						oxygen.value += Strength;
						carbonLevel.level.value -= (oxygen.difference / 5f);
			
				}		
		}

		public void BreathOut ()
		{
				oxygen.value -= Strength;
		}

		float Strength {
				get {
						return Mathf.Max (carbonLevel.level.value / 15.0f, 0.0006f);
				}
		}

		private CarbonLevel carbonLevel {
				get {
						return GetComponent<CarbonLevel> ();
				}
		}

		
}
