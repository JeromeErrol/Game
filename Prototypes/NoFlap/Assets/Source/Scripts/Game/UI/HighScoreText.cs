using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace NoFlap.Game.UI
{
	[RequireComponent (typeof(Text))]
	public class HighScoreText : MonoBehaviour
	{
		private Text label;
		
		void Awake ()
		{
			label = GetComponent<Text> ();
		}
		
		void Update ()
		{
			label.text = "High Score: " + Score.HighScore;
		}
	}
}
