using UnityEngine;
using System.Collections;

public class Obstacle : PlayerInteractive
{
	public override void CollisionWithPlayer (Player player)
	{
		Level.instance.LoseLife ();
	}		
}

