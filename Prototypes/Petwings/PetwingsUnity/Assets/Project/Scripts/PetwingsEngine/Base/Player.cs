using UnityEngine;
using System.Collections;

namespace Petwings.Engine.Base
{
		public class Player : MonoBehaviour
		{
				public static Player Instance;

				void Awaken ()
				{
						Player.Instance = this;
				}

				public void Die ()
				{
						GameObject.Destroy (gameObject);
				}
		}
}
