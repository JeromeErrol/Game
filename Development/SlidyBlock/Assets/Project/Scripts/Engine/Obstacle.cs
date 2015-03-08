using UnityEngine;
using System.Collections;

public class Obstacle : PlayerInteractive
{
		public override void PlayerEntered (Player player)
		{		
				GameFSM.RestartLevel ();
		}
}
