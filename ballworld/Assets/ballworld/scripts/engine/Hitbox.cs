using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public GameObject owner;
    public bool destroyOnCollision = false;
    public float force = 1f;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject != owner)
        {
            Unit unit = collider.GetComponent<Unit>();

            if (unit != null)
            {
                unit.takeDamage();
                unit.addForce(-transform.right, force);

                if(destroyOnCollision)
                {
                    DestroyObject(gameObject);
                }
            }
        }
    }
}
