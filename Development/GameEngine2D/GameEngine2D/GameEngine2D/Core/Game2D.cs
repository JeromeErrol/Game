using UnityEngine;
using System.Collections;

public class Game2D : MonoBehaviour
{
	private static Game2D instance;
	public float gameSpeed = 1.0f;
	public bool paused = false;
	public bool debugMode = true;
	private float gameTimePassed = 0;
	public float framerate = 60f;

	void Start ()
	{
		instance = this;
		Camera.main.gameObject.GetOrCreateComponent<OrthographicsCameraManager> ();
		gameObject.GetOrCreateComponent<UserInputManager> ();
	}

	void FixedUpdate ()
	{
		gameTimePassed += Game2D.GameSpeed;
	}

	public static float FrameRate {
		get {
			return instance.framerate;
		}
	}

	public static bool Paused {
		get {
			return instance.paused;
		}set {
			instance.paused = value;
		}
	}

	public static float GameTimePassed {
		get {
			return instance.gameTimePassed;
		}
	}

	public static float GameSpeed {
		get {
			if (instance.paused) {
				return 0;
			} else {
				return instance.gameSpeed * (instance.framerate / Time.deltaTime);
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

