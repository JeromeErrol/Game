using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserInputManager : MonoBehaviour
{
		private bool pressed = false;
		public List<UserInteractive> itemsClicked = new List<UserInteractive> ();

		void Update ()
		{
				RuntimePlatform platform = Application.platform;

				if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
						if (Input.touchCount > 0) {
								if (Input.GetTouch (0).phase == TouchPhase.Began) {
										if (!pressed) {
												pressed = true;
												checkTouch (Input.GetTouch (0).position);
										}
								}
						} 
				} else if (Application.platform == RuntimePlatform.WindowsEditor) {
						if (Input.GetMouseButtonDown (0)) {
								if (!pressed) {
										print ("Pressed");
										pressed = true;

										Vector3 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
										Vector2 touchPos = new Vector2 (wp.x, wp.y);
										//var hit = Physics2D.OverlapPoint (touchPos);
										Collider2D[] collisions = Physics2D.OverlapCircleAll (wp, 1f);
										foreach (Collider2D collision in collisions) {
												UserInteractive userInteractive = collision.transform.gameObject.GetComponent<UserInteractive> ();
												if (userInteractive != null) {
														itemsClicked.Add (userInteractive);
												}
										}
										//	if (hit) {
										//			UserInteractive userInteractive = hit.transform.gameObject.GetComponent<UserInteractive> ();
										//			if (userInteractive != null) {
										//					itemsClicked.Add (userInteractive);
										//			}
										//	}
								}
						} else if (Input.GetMouseButtonUp (0)) {
								if (pressed) {
										pressed = false;
										print ("Released");
										
										foreach (UserInteractive userInteractive in itemsClicked) {
												userInteractive.Pressed ();
										}
										itemsClicked.Clear ();
								}
						}
				}
		}
	
		void checkTouch (Vector3 pos)
		{
				Vector3 wp = Camera.main.ScreenToWorldPoint (pos);
				Vector2 touchPos = new Vector2 (wp.x, wp.y);
				var hit = Physics2D.OverlapPoint (touchPos);
				if (hit) {
						UserInteractive userInteractive = hit.transform.gameObject.GetComponent<UserInteractive> ();
						if (userInteractive != null) {
								userInteractive.Pressed ();
						}
				}
		}
}

