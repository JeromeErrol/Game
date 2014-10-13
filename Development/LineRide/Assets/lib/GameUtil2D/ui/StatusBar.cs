using UnityEngine;
using System.Collections;

namespace GameUtil2D
{
		public class StatusBar : MonoBehaviour
		{
				public Cap cap;
				public float startingValue;
				public float startingMax;
				public float height;
				public float width;
				public Vector2 position;
				public string textValue;

				void Start ()
				{
						cap = new Cap (startingValue, startingMax);
				}

				void OnGUI ()
				{
						float diff = height - (height * cap.Percent);
						GUIStyle style = new GUIStyle (GUI.skin.box);
						float filledHeight = Mathf.Max (0, height * cap.Percent);
						GUI.Box (new Rect (position.x, position.y + diff, width, filledHeight), "");
						GUI.Box (new Rect (position.x, position.y, width, height), textValue, style);
				}
		}
}
