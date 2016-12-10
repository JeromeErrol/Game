using UnityEngine;

public static class Trig {

    public static float degreesBetween(Transform transform, Transform otherTransform)
    {
        Vector3 relative = transform.position - otherTransform.position;
        Vector3 point = Quaternion.Inverse(otherTransform.rotation) * relative;

        if (point.x < 0)
        {
            return 360 - (Mathf.Atan2(point.x, point.y) * Mathf.Rad2Deg * -1);
        }
        else
        {
            return Mathf.Atan2(point.x, point.y) * Mathf.Rad2Deg;
        }
    }

    public static Quaternion rotationBetween(Transform source, Transform target)
    {
        return Quaternion.LookRotation(source.transform.forward, target.transform.position - source.position);
    }

    public static bool approx(float a, float b, float range)
    {
        float halfRange = Mathf.Abs(range / 2);
        return a > b - halfRange && a < b + halfRange;
    }

    public static float difference(float a, float b)
    {
        return Mathf.Abs(a - b);
    }

    public static float degreesDifference(float a, float b)
    {
        return (a - b) % 360;
    }
}
