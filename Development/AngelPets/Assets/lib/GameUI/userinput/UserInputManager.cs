using UnityEngine;
using System.Collections;

public class UserInputManager : MonoBehaviour
{
		void Update ()
		{
				RuntimePlatform platform = Application.platform;

				if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
						if (Input.touchCount > 0) {
								if (Input.GetTouch (0).phase == TouchPhase.Began) {
										checkTouch (Input.GetTouch (0).position);
								}
						}
				} else if (Application.platform == RuntimePlatform.WindowsEditor) {
						if (Input.GetMouseButtonDown (0)) {
								checkTouch (Input.mousePosition);
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
