using UnityEngine;
using System.Collections;

public class FinishLine : PlayerInteractive
{
	public override void PlayerEnter (Player player)
	{
		Level.instance.NextLevel ();
	}
}

