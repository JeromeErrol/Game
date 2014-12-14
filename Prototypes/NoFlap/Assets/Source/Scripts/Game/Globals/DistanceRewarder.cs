using UnityEngine;
using System.Collections;

public class DistanceRewarder : MonoBehaviour
{
		private static DistanceRewarder instance;

		void Awake ()
		{
				instance = this;
		}
}

