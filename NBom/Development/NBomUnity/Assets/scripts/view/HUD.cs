using UnityEngine;
using System.Collections;
using GameUtil2D;

public class HUD : MonoBehaviour
{
		private const float StandardHeight = 30;
		private const float StandardWidth = 130;
		private float fuelHeight = 100;
		private float fuelWidth = 100;
		private float fuelX = 0;
		private float fuelY = 30;
		private float pointsX = 0;
		private float pointsY = 0;
		private float chargeX = 0;
		private float chargeY = 200;
		private float cameraToggleX = 0;
		private float cameraToggleY = 0;
		private float activateThrustX = 0;
		private float activateThrustY = 0;
		private float activateTeleportX = 0;
		private float activateTeleportY = StandardHeight;
		private float resetX;
		private float resetY;
		private float chargeBarX = 0;
		private float chargeBarY = 110;
		private float chargeBarWidth = 100;
		private float chargeBarHeight = StandardHeight;

		public int cameraIndex = 0;
	public float[] cameraDistance = {-50f, -100f, -150f};
		
		void incrementCameraIndex(){
			cameraIndex = (cameraIndex+ 1) % cameraDistance.Length;
		}
	
		void Start ()
		{
				resetY = Screen.height - StandardHeight;
				cameraToggleY = resetY - StandardHeight;
				fuelX = Screen.width - fuelWidth;
				pointsX = Screen.width - fuelWidth;

				chargeBarX = Screen.width - chargeBarWidth;
				chargeBarY = fuelY + fuelHeight;
		}

		void OnGUI ()
		{
				
				DrawFuel ();
				DisplayCameraToggle ();

				DisplayTeleport ();
				DisplayResetButton ();
				if (gameObject.GetComponent<ChargeThruster> ()) {
						DisplayToggleThrustAbility ();
						DisplayChargeBar ();
				}
				DrawPoints ();
		}

		void DisplayResetButton ()
		{
				if (GUI.Button (new Rect (resetX, resetY, StandardWidth, StandardHeight), "Reset")) {
						Application.LoadLevel ("demo");
				}
		}

		void DisplayToggleThrustAbility ()
		{
				if (GUI.Button (new Rect (activateThrustX, activateThrustY, StandardWidth, StandardHeight), "Thrust")) {
						setAbility (Ability.Thrust);
				}
		}

		void setAbility (Ability ability)
		{
				gameObject.GetComponent<RocketShipController> ().abilitySelected = ability;
		}

		void DisplayCameraToggle ()
		{
				if (GUI.Button (new Rect (cameraToggleX, cameraToggleY, StandardWidth, StandardHeight), "Toggle Camera")) {
					incrementCameraIndex();
					CameraUtil2D.SetZ (cameraDistance[cameraIndex]);			   
				}
		}

		void DisplayTeleport ()
		{				
				if (rocketShip.teleport) {

						if (GUI.Button (new Rect (activateTeleportX, activateTeleportY, StandardWidth, StandardHeight), "Save Teleport")) {
								rocketShip.teleport.SavePosition();
						}
						if (rocketShip.teleport.Activated) {
								if (GUI.Button (new Rect (activateTeleportX, activateTeleportY + StandardHeight, StandardWidth, StandardHeight), "Activate Teleport")) {
									rocketShip.teleport.Activate();
								}
						}	
				}			
		}

		RocketShip rocketShip {
				get {
			return Level.instance.rocketShip;
				}
		}

		void DisplayChargeBar ()
		{
				float percentCharged = rocketShip.GetComponent<ChargeThruster> ().PercentCharged;
				GUI.Box (new Rect (chargeBarX, chargeBarY, chargeBarWidth, chargeBarHeight), "");
				if (percentCharged > 0.1) {
						GUI.Box (new Rect (chargeBarX, chargeBarY, chargeBarWidth * percentCharged, chargeBarHeight), "");
				}
		}

		void DrawPoints ()
		{
				if (rocketShip) {
					GUI.Box (new Rect (pointsX, pointsY, fuelWidth, 30), "Points: " + rocketShip.points);
				}				
		}

		void DrawFuel ()
		{
				FuelTank fuelTank = gameObject.GetComponent<FuelTank> ();
				if (fuelTank) {
						float diff = fuelHeight - (fuelHeight * fuelTank.PercentRemaining);
						GUIStyle style = new GUIStyle (GUI.skin.box);
						float newHeight = Mathf.Max (0, fuelHeight * fuelTank.PercentRemaining);
						GUI.Box (new Rect (fuelX, fuelY + diff, fuelWidth, newHeight), "");
						GUI.Box (new Rect (fuelX, fuelY, fuelWidth, fuelHeight), fuelTank.Remaining + "/" + fuelTank.Capacity, style);

				}		
		}

}