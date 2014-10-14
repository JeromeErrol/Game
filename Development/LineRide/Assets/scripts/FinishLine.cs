using UnityEngine;
using System.Collections;

public class FinishLine : PlayerInteractive
{
	public override void CollisionWithPlayer (Player player)
	{
		Level.instance.NextLevel ();
	}
}

