using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
		public static Game Instance;
		private int _currentFrame = 0;
		private float gameSpeedStore;
		private bool paused = false;

		void Awake ()
		{
				Instance = this;
				gameObject.GetOrCreateComponent<Speed> ();
				gameObject.GetOrCreateComponent<Fps> ();
		}
	
		void FixedUpdate ()
		{
				_currentFrame++;
				print (Time.deltaTime);
		}
		
		public int CurrentFrame {
				get {
						return _currentFrame;
				}
		}

		public bool Paused {
				get {
						return paused;
				}set {
						if (value) {
								Speed speed = gameObject.GetOrCreateComponent<Speed> ();
								gameSpeedStore = speed.value;
								speed.value = 0;
								paused = true;
						} else {
								gameObject.GetOrCreateComponent<Speed> ().value = gameSpeedStore;
								paused = false;
						}
				}

		}
}

