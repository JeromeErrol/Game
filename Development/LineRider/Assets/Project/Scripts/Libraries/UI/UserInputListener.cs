using UnityEngine;
using System.Collections;

public class UserInputListener : MonoBehaviour
{
		void Update ()
		{
				if (Input.GetMouseButtonDown (0)) {
						RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
						if (hit.collider != null) {
								UIComponent uiComponent = hit.collider.gameObject.GetComponent<UIComponent> ();
								if (uiComponent != null) {
										uiComponent.Clicked ();
								}
						}
				}
		}
}

