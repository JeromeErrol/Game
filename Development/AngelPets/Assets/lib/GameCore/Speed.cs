using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{
		public float value = 1.0f;
		public Speed relativeTo;

		public float RelativeSpeed {
				get {
						if (relativeTo != null) {
								return this.value * relativeTo.RelativeSpeed;
						} else {
								return this.value / Time.deltaTime / 50f;
						}
				}
		}
}

