using UnityEngine;
using System.Collections;

public class Game2D : MonoBehaviour
{
		private static Game2D instance;
		public float gameSpeed = 1.0f;
		public bool paused = false;
		public bool debugMode = true;

		void Start ()
		{
				instance = this;
				Camera.main.gameObject.GetOrCreateComponent<OrthographicsCameraManager> ();
		}

		public static bool Paused {
				get {
						return instance.paused;
				}set {
						instance.paused = value;
				}
		}

		public static float GameSpeed {
				get {
						if (instance.paused) {
								return 0;
						} else {
								return instance.gameSpeed * (1f / Time.deltaTime);
						}
						
				}set {
						Mathf.Max (0, instance.gameSpeed = value);
				}
		}

		public static bool DebugMode {
				get {
						return instance.debugMode;
				}set {
						instance.debugMode = value;
				}
		}
}

