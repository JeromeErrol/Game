using UnityEngine;
using System.Collections;

public class SmallPill : Collectable {

	public override void CollectedBy (Player player)
	{
		Vector3 scale = player.transform.localScale;
		scale /= 2;
		player.transform.localScale = scale;
	}
}
