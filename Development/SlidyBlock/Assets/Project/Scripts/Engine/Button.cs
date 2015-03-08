using UnityEngine;
using System.Collections;
using System;

public class Button : PlayerInteractive
{
		public Action action;

		public override void PlayerEntered (Player player)
		{
				if (action != null) {
						action ();
				}
		}
}

