using UnityEngine;
using System.Collections;

public class HUDFPS : Text2D
{
	protected override void UpdateText ()
	{
		text = System.String.Format ("{0:F2} FPS", Fps.Value) + " delta time:" + Time.deltaTime;
	}
}