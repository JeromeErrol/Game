using UnityEngine;
using UnityEditor;
using System.Collections;
using GameUtil2D;

public class SnapToGrid : ScriptableObject {
	
	[MenuItem ("Window/Snap to Grid %g")]
	static void MenuSnapToGrid() {
		foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {		
			CustomSnap gridSnap = t.GetComponent<CustomSnap>();
			if(gridSnap){
				gridSnap.Snap();
			}else{
				float x = MathUtil2D.RoundOff (t.position.x, 5);
				float y = MathUtil2D.RoundOff (t.position.y, 5);
				t.position = new Vector3 (x, y, t.position.z);	
			}
		}
	}

	
}