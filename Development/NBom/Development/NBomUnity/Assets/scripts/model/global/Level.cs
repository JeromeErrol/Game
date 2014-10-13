using UnityEngine;
using System.Collections;

public class Level:MonoBehaviour
{
	public RocketShip rocketShip;
	public string levelName;

	public static Level instance;

	void Start(){
		instance = this;
	}	
}

