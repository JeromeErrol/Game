
public class Projectile : BallworldObject {

    public float speed = 0.7f;
    public float range = 50f;
    private float distanceTravelled = 0;

    void Update()
    {
        moveForward(speed);
        distanceTravelled += speed;

        if (distanceTravelled > range)
        {
            DestroyObject(gameObject);
        }
    }
}
