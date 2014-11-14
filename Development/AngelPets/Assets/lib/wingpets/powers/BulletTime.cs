using UnityEngine;
using System.Collections;

public class BulletTime : Power
{
		public float gameSpeed;
		public float playerBoost;

		public override void Activated ()
		{
				Game.Instance.Speed ().value = gameSpeed;
				Player.instance.Speed ().value += playerBoost;
		}
	
		public override void Deactivated ()
		{
				Game.Instance.Speed ().value = 1f;
				Player.instance.Speed ().value = 1f;
		}
}

