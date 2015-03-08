using UnityEngine;
using System.Collections;

public class Key : PlayerInteractive
{
		public override void PlayerEntered (Player player)
		{
				SoundLibrary.PlayKeyCollected ();
				GameObject.Destroy (gameObject);
		}

		public static bool AreRemaining ()
		{
				return GameObject.FindObjectsOfType<Key> ().Length > 0;
		}
}

