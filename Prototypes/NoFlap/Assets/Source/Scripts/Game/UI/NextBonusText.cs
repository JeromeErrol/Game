using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace NoFlap.Game.UI
{
	[RequireComponent (typeof(Text))]
	public class NextBonusText : MonoBehaviour
	{
		private Text label;
		
		void Awake ()
		{
			label = GetComponent<Text> ();
		}
		
		void Update ()
		{
			label.text = "Next Bonus: " + CollectablesManager.NextCollectionValue;
		}
	}
}
