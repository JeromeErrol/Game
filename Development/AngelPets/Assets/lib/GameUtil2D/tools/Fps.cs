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

		void Start ()
		{
				timeleft = updateInterval;  
		}

		public override string ToString ()
		{
				return System.String.Format ("{0:F2} FPS", fps);
		}

		public float GetValue {
				get {
						return fps;
				}
		}

		public static float Value {
				get {
						return _Value;
				}
		}

	
		void Update ()
		{
				timeleft -= Time.deltaTime;
				accum += Time.timeScale / Time.deltaTime;
				++frames;
		
				// Interval ended - update GUI text and start new interval
				if (timeleft <= 0.0) {
						// display two fractional digits (f2 format)
						fps = accum / frames;
						_Value = fps;
						//	DebugConsole.Log(format,level);
						timeleft = updateInterval;
						accum = 0.0F;
						frames = 0;
				}
		}
}