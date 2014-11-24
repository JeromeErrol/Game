using UnityEngine;
using System.Collections;
using GameUtil2D;

public class MotionDrift : MonoBehaviour
{
		private GameObject particle;

		void Start ()
		{
				particle = StageUtil2D.AddGameObject (Resources2D.DriftLine);
		}

		void Update ()
		{
				particle.transform.position = gameObject.transform.position;
				particle.transform.rotation = gameObject.transform.rotation;
		}
}
