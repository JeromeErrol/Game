using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
		private static Scene instance;
		private PlayMakerFSM fsm;

		void Awake ()
		{
				instance = this;
				fsm = GetComponent<PlayMakerFSM> ();
		}

		public static void Reload ()
		{
				instance.fsm.SendEvent ("Reload");
		}
}

