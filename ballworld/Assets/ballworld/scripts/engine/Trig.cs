using UnityEngine;

public static class Trig {

    public static float degreesBetween(Transform transform, Transform otherTransform)
    {
        Vector3 relative = transform.position - otherTransform.position;
        Vector3 point = Quaternion.Inverse(otherTransform.rotation) * relative;
        Vector2 point2 = new Vector2(point.x, point.y);

        if (point2.x < 0)
        {
            return 360 - (Mathf.Atan2(point2.x, point2.y) * Mathf.Rad2Deg * -1);
        }
        else
        {
            return Mathf.Atan2(point2.x, point2.y) * Mathf.Rad2Deg;
        }
    }
}
