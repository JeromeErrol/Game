using UnityEngine;
using System.Collections;

public class BulletTime : Power
{

		public override void Activated ()
		{
				Game.Instance.Speed ().value = GameState.Instance.bulletTimeGameSpeed;
				Player.instance.Speed ().value += GameState.Instance.bulletTimePlayerBoost;
		}
	
		public override void Deactivated ()
		{
				Game.Instance.Speed ().value = 1f;
				Player.instance.Speed ().value = 1f;
		}
}

