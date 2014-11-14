using UnityEngine;
using System.Collections;

public class Glow : MonoBehaviour
{
		public float maxAlpha;
		public float minAlpha;
		public float changeRate;

		void Start ()
		{
			gameObject.SetAlpha ((maxAlpha + minAlpha) / 2);
		}

		void FixedUpdate ()
		{
				float alpha = gameObject.GetAlpha ();
				alpha += changeRate;
				gameObject.SetAlpha (alpha);
				if (gameObject.GetAlpha () > maxAlpha || alpha < this.minAlpha) {
						changeRate = -changeRate;
				}
		}
}

