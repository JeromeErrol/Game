using UnityEngine;
using System.Collections;

public abstract class InputController : MonoBehaviour
{
	public abstract bool TriggerPulled();
	public abstract Vector2 TriggerLocation();
}

