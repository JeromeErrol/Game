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
								float val = this.value * (50f / (1f / Time.deltaTime));
								return val;
						}
				}
		}
}

