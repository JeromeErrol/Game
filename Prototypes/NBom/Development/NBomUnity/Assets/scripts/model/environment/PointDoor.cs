using UnityEngine;
using System.Collections;

public class PointDoor : ICollideable {

	public int cost;
	SpriteRenderer spriteRenderer;
	public RocketShip rocketShip;

	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void Update(){
		GetComponent<BoxCollider2D> ().isTrigger = Affordable;
	}

	public override void CollidedWith (RocketShip rocketShip)
	{
		if (Affordable) {
			rocketShip.points -= cost;
			Destroy (gameObject);
		} 
	}

	bool Affordable{
		get{
			if(rocketShip){
				return rocketShip.points >= cost;
			}else{
				return true;
			}
		}
	}

	void FixedUpdate(){
		if (!Affordable) {		
						spriteRenderer.color = Color.red;
				} else {
			spriteRenderer.color = Color.white;
				}
	}
}
