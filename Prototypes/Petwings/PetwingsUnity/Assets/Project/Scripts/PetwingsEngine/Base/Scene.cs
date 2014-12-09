using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
		public static Scene Instance;
		
		void Awake ()
		{
				Instance = this;
		}

		void Reload ()
		{
				PlayMakerFSM fsm = gameObject.GetComponent<PlayMakerFSM> ();
		}
}

