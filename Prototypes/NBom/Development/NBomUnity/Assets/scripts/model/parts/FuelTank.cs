using UnityEngine;
using System.Collections;

public class FuelTank : MonoBehaviour{
	
	public float capacity;
	public float remaining;

	public FuelTank(float capacity, float amount){
		this.capacity = capacity;
		this.remaining = amount;
	}

	public float Capacity{
		get{
			return capacity;
		}set{
			if(value > 0){
				capacity = Mathf.Max(value, 0);
				remaining = Mathf.Min(remaining, capacity);
			}
		}
	}

	public float PercentRemaining{
		get{
			return Remaining / Capacity;
		}
	}

	public float Remaining{
		get{
			return remaining;
				}set{
			if(value > 0){
				remaining = Mathf.Min(value, capacity);
			}else{
				remaining = 0;
			}
		}
	}

	public void BurnFuel ()
	{
		Remaining -= 1;
	}
	
	public void Refill(float amount){
		remaining += amount;
		if (remaining > capacity) {
			remaining = capacity;
		}
	}
	
	
	public bool FuelIsRemaining {
		get {
			return remaining > 0;
		}
	}

	
}
