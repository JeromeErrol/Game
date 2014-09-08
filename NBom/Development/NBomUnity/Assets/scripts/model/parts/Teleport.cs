using System;
using UnityEngine;
using GameUtil2D;

public class Teleport: MonoBehaviour
{ 
		private GameObject teleportObject;

		void Start ()
		{	
				teleportObject = StageUtil.AddGameObject (Asset2DUtil.Circle01);
				teleportObject.renderer.enabled = false;
		}

		public void Activate ()
		{
				if (Activated) {
						gameObject.transform.position = savedPosition;	
						Deactivate ();						
				}
		}

		public void Deactivate ()
		{
				teleportObject.renderer.enabled = false;
		}

		public bool Activated {
				get {
			return teleportObject.renderer.enabled;
				}
		}

		public void SavePosition ()
		{
				savedPosition = gameObject.transform.position;
				teleportObject.transform.position = savedPosition;		
				teleportObject.renderer.enabled = true;
		}

		public Vector3 savedPosition {
				get {
						return teleportObject.transform.position;
				}set {
						teleportObject.transform.position = value;
				}
		}
}

