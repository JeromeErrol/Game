using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public GameObject owner;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject != owner)
        {
            Unit unit = collider.GetComponent<Unit>();

            if (unit != null)
            {
                unit.takeDamage();
                unit.addForce(-transform.right, 1f);

                if(GetComponent<Arrow>() != null)
                {
                    DestroyObject(gameObject);
                }
            }
        }
    }
}
