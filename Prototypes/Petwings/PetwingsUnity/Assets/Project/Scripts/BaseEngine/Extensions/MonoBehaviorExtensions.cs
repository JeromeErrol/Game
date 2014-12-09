using UnityEngine;
using System.Collections;

namespace BaseEngine.Extensions
{
		public static class MonoBehaviorExtensions
		{
				public static T GetOrCreateComponent<T> (this MonoBehaviour behavior)where T:Component
				{
						T componant = behavior.GetComponent<T> ();
						if (componant == null) {
								componant = behavior.gameObject.AddComponent<T> ();
						}
						return componant;
				}
		}
}

