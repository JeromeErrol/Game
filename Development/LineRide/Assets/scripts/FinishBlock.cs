using UnityEngine;
using System.Collections;

public class FinishBlock : PlayerInteractive {

	public override void CollisionWithPlayer (Player player)
	{
		Level.instance.NextLevel ();
	}
}
