using UnityEngine;
using System.Collections;

public class Boost : Power
{
		public float boostValue;

		public override void Activated ()
		{
				Player.instance.Speed ().value = boostValue;
		}

		public override void Deactivated ()
		{
			Player.instance.Speed ().value = 1f;
		}
}

