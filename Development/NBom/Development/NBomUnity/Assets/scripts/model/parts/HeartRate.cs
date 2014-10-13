using UnityEngine;
using System.Collections;
using GameUtil2D;

public class HeartRate : MonoBehaviour
{
		public Cap level = new Cap (0, 100);

		void Update ()
		{
				Rest ();
				CarbonLevel carbonLevel = gameObject.GetComponent<CarbonLevel> ();
				carbonLevel.level.value += Mathf.Max (0.00055f, (level.value / 10000f));
		}

		public void Tire ()
		{		
				level.value += 0.4f;
		}

		public void Rest ()
		{
				level.value -= 0.3f;
		}
}

