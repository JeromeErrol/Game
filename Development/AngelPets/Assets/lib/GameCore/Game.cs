using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
		public static Game Instance;
		private int _currentFrame = 0;

		void Awake ()
		{
				Instance = this;
		}
	
		void Update ()
		{
				_currentFrame++;
		}
		
		public int CurrentFrame {
				get {
						return _currentFrame;
				}
		}
}

