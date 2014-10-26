using UnityEngine;
using System.Collections;

public class DisplayLevel : MonoBehaviour
{
		public GUIStyle style;
		public float fadeInTime;
		public float stayTime;
		public float fadeOutTime;
		int step = 1;
		public Color color;
		int currentFrame = 0;

		private float currentOpacity = 0;

		// Use this for initialization
		void Start ()
		{
			SetStyleA (0);
		}

		void SetStyleA(float a){
			Color Acolor = color;
			Acolor.a = a;
			style.normal.textColor = Acolor;

		//	Color colorSave = GUI.color;
			GUI.color = color;
			
		}

		float ChangeRate{
			get{
				switch(step){

			case 1:
				return 1f / fadeInTime;
			case 2:
				return 0;
			case 3:
				return -1f / fadeOutTime;
			default:
				return 0;

				}
			}
		}

		int getOpacity{
			get{
				return (int)currentOpacity;
			}
		}
	
		// Update is called once per frame
		void Update ()
		{
				currentFrame++;

				if (step == 1 && currentFrame > fadeInTime) {
						step = 2;
						currentFrame = 0;
				} else if (step == 2 && currentFrame > stayTime) {
						step = 3;
						currentFrame = 0;
				} else if (step == 3 && currentFrame > fadeOutTime) {
						step = 4;
				}		
				
				currentOpacity += ChangeRate;
				
				SetStyleA (getOpacity);
		}

		

		public string LevelText {
				get {
						return "Level " + Level.instance.level;
				}
		}

		void OnGUI ()
		{
				GUI.Label (new Rect (100, 100, 100, 50), LevelText, style);
		}
}

