using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public float fuelHeight;
	public float fueldWidth;
	public float fuelX = 0;
	public float fuelY = 30;

	public float pointsX = 0;
	public float pointsY = 200;
	
	public RocketShip rocketShip;

	void OnGUI () {
		DrawFuel ();
		DrawPoints ();
	}

	void DrawPoints(){
		GUI.Box(new Rect(pointsX, pointsY, fueldWidth, 30), "Points: " + rocketShip.points);
	}

	void DrawFuel(){

		float diff = fuelHeight - (fuelHeight * rocketShip.fuelTank.PercentRemaining);
		GUIStyle style = new GUIStyle(GUI.skin.box );
		float newHeight = Mathf.Max (0, fuelHeight * rocketShip.fuelTank.PercentRemaining);
		GUI.Box(new Rect(fuelX, fuelY + diff, fueldWidth, newHeight), "");
		GUI.Box(new Rect(fuelX, fuelY, fueldWidth, fuelHeight), rocketShip.fuelTank.Remaining + "/" + rocketShip.fuelTank.Capacity, style);
	}

}