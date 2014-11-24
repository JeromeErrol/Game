using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameUtil2D;

public class RainGenerator : MonoBehaviour
{
		public float heaviness = 100;
		private float nextRaindrop = 0;
		public List<GameObject> activeRaindrops = new List<GameObject> ();
		public List<GameObject> availableRaindrops = new List<GameObject> ();
		public GameObject raindrops;	
		public float windDirection;
		public float windStrength;

		// Use this for initialization
		void Start ()
		{
				raindrops = new GameObject ("Rain Drops");
		}

		void Update ()
		{
				nextRaindrop--;
				if (nextRaindrop <= 0) {
						nextRaindrop = heaviness;
						spawnRainDrop ();
				}
		}

		public void spawnRainDrop ()
		{
				float x = Random.Range (0, 28);			
				Vector3 position = new Vector3 (x, 10, 0);
				GameObject go = StageUtil2D.AddGameObject (Res.raindrop, position);	
				go.name = "Rain Drop";
				go.AddComponent<RainDrop> ();			
				go.transform.localScale = new Vector3 (0.1f, 0.1f, 1f);
				go.transform.parent = raindrops.transform;
		}
}

