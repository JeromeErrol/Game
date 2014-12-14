using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace NoFlap.Game.UI
{
	[RequireComponent (typeof(Text))]
	public class StreakText : MonoBehaviour
	{
		private Text label;
		
		void Awake ()
		{
			label = GetComponent<Text> ();
		}
		
		void Update ()
		{
			label.text = "Streak: " + CollectablesManager.CurrentStreak;
		}
	}
}
