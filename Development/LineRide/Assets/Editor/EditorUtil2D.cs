using UnityEngine;
using UnityEditor;
using System.Collections;
using GameUtil2D;

public class CustomSnap : MonoBehaviour
{
		public float snapSize;
		
		public void Snap ()
		{						
				float x = MathUtil2D.RoundOff (transform.position.x, snapSize);
				float y = MathUtil2D.RoundOff (transform.position.y, snapSize);
				transform.position = new Vector3 (x, y, transform.position.z);	
		}
}

public class SnapToGrid : ScriptableObject
{
		public static float SNAPSIZE = 5f;
		public static float SQUARE_SIZE = 10f;
		public static float HALF_SQUARE = 5f;
		
		[MenuItem ("Window/Snap to Grid %g")]
		static void MenuSnapToGrid ()
		{
				foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {		
						CustomSnap gridSnap = t.GetComponent<CustomSnap> ();
						if (gridSnap) {
								gridSnap.Snap ();
						} else {
								float x = MathUtil2D.RoundOff (t.position.x, 5f);
								float y = MathUtil2D.RoundOff (t.position.y, 5f);
								t.position = new Vector3 (x, y, t.position.z);	
						}
				}
		}
		
		[MenuItem ("Window/Snap to Grid HALF %h")]
		static void MenuSnapToGridQuarter ()
		{
				foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {		
						CustomSnap gridSnap = t.GetComponent<CustomSnap> ();
						if (gridSnap) {
								gridSnap.Snap ();
						} else {
								float x = MathUtil2D.RoundOff (t.position.x, 2.5f);
								float y = MathUtil2D.RoundOff (t.position.y, 2.5f);
								t.position = new Vector3 (x, y, t.position.z);	
						}
				}
		}

		[MenuItem ("Window/Find Problems %p")]
		public static void FindProblems ()
		{
				foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {		
					DiagnoseProblems(t);
				}
		}

		public static void DiagnoseProblems(Transform t){
				
					GoToDestination goToDestination = t.GetComponent<GoToDestination> ();
					if (goToDestination != null) {
						DiagnoseGoToDestination(goToDestination);
					}
		}

		public static void DiagnoseGoToDestination(GoToDestination goToDestination){
				if (goToDestination.destination == null) {
					MonoBehaviour.print("Missing Destination");
				}
		}

}