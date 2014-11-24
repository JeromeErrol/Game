using UnityEngine;
using System.Collections;

public class Fps : MonoBehaviour
{
		public  float updateInterval = 0.5F;
		private float accum = 0; // FPS accumulated over the interval
		private int   frames = 0; // Frames drawn over the interval
		private float timeleft; // Left time for current interval
		private float fps = 0;
		private static float _Value = 0;
		private static float _Correction = 1;
		public static float GameSpeed = 1.0f;
		public float gameSpeed = 1.0f;
		public static int FRAME = 0;

		void Start ()
		{
				timeleft = updateInterval;  
		}

		public override string ToString ()
		{
				return System.String.Format ("{0:F2} FPS", fps) + " delta time:" + Time.deltaTime;
		}

		public float GetValue {
				get {
						return fps;
				}
		}

		public static float Correct {
				get {
						return _Correction;
				}
		}

		public static float Value {
				get {
						return _Value;
				}
		}
	
		void Update ()
		{
				FRAME++;
				timeleft -= Time.deltaTime;
				accum += Time.timeScale / Time.deltaTime;
				++frames;
				fps = accum / frames;
				Fps.GameSpeed = gameSpeed;
				_Correction = (60 / Mathf.Max (1, Fps.Value)) * GameSpeed;
				_Value = fps;
				
				// Interval ended - update GUI text and start new interval
				if (timeleft <= 0.0) {
						// display two fractional digits (f2 format)
						//	DebugConsole.Log(format,level);
						timeleft = updateInterval;
						accum = 0.0F;
						frames = 0;
				}
		}
}