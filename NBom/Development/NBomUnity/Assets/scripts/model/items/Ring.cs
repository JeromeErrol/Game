using UnityEngine;
using System.Collections;

public class Ring:ICollectable
{
		public int value;
	
		public Ring ()
		{
		
		}

		public override void CollectedBy (RocketShip rocketShip)
		{
			rocketShip.points += value;

		}

		
	
}


