
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	private float column1 = 20;
	private float row1 = 20;

	private float column2 = 80;
	private float row2 = 80;

	private float standardWidth = 120;
	private float standardHeight = 30;
		
	void OnGUI ()
	{
		if(GUI.Button (new Rect (column1, row1, standardWidth, standardHeight), "Empty Slot")){
			Application.LoadLevel ("level1");
		}	

		if(GUI.Button (new Rect (column1, row2, standardWidth, standardHeight), "Empty Slot")){
			
		}
	}
}
