using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
		public string title;
		public static Scene instance;

		void Start ()
		{
				instance = this;
		}

		public void RestartScene ()
		{
				Application.LoadLevel (title);
		}
}

