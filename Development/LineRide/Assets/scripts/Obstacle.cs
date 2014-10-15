using UnityEngine;
using System.Collections;

public class Obstacle : PlayerInteractive
{
	public override void PlayerEnter (Player player)
	{
		Level.instance.LoseLife ();
	}		
}

