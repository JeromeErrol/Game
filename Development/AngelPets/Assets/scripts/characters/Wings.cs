using UnityEngine;
using System.Collections;

public class Wings : MonoBehaviour
{
		private float nextFlap = 0;
		public float timeBetweenFlaps;
		public bool up = true;
		public int flapCount = 10;
		public float flapHeightSpeed = 0.01f;
		private int flapIndex;
		private int direction = 1;

		void Start ()
		{
				nextFlap = timeBetweenFlaps;
		}

		void Update ()
		{
				Flap ();

				nextFlap--;
				if (nextFlap <= 0) {
						nextFlap = timeBetweenFlaps;
				}
		}

		private void Flap ()
		{
				flapIndex += direction;
				if (flapIndex == flapCount || flapIndex == -flapCount) {
						direction = -direction;
				} else {
						Vector3 pos = Player.instance.gameObject.transform.position;
						pos.y += (flapHeightSpeed * direction);
						Player.instance.gameObject.transform.position = pos;
				}
		}
}

