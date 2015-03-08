using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventHistory
{
	public static List<GameEvent> states = new List<GameEvent>();	

	public static void Add(GameEvent gameState){
		states.Add (gameState);
	}

	public static GameEvent LastState{
		get{
			if(states.Count > 0){
				return states[states.Count - 1];
			}else{
				return GameEvent.Empty;
			}
		}
	}
}

