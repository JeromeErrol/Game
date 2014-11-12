using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{
		public float value = 1.0f;
		public Speed relativeTo;

		public float RelativeSpeed {
				get {
						if (relativeTo != null) {
								return value * relativeTo.RelativeSpeed;
						} else {
								return value;
						}
				}
		}
}

