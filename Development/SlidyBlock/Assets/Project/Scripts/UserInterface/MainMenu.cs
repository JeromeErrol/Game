using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
		public static string currentLevel = "scene01";

		public void Play ()
		{
				Application.LoadLevel (currentLevel);
		}
}

