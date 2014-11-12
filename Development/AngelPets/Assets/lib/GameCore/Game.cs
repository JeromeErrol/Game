using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
		public static Game Instance;
		private int _currentFrame = 0;

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
}

