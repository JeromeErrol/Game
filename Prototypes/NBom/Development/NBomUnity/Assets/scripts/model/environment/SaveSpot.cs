using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveSpot : IOverlap {

	public static List<SaveSpot> SaveSpots = new List<SaveSpot>();
	public bool activated;
	public string name;
	private bool menuVisible = false;
	private RocketShip rocketShip;

	// Use this for initialization
	void Start () {
		SaveSpots.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OverlapTriggered (RocketShip rocketShip)
	{
		menuVisible = true;
		this.rocketShip = rocketShip;
	}

	public override void ExitTriggered (RocketShip gameObject)
	{
		menuVisible = false;
	}

	void OnGUI ()
	{
		if (menuVisible) {

			float x = 200;
			float y = 100;
			if (GUI.Button (new Rect (x, y, 120, 30), "Save")) {
				
			}			


			foreach(SaveSpot savespot in SaveSpots){
				y += 30;
				if (GUI.Button (new Rect (x, y, 120, 30), savespot.name)) {
					savespot.TeleportTriggered(rocketShip);
				}	
			}
		}
	}

	void TeleportTriggered(RocketShip rocketShip){
		rocketShip.transform.position = transform.position;
	}




}
