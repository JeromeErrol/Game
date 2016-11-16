using UnityEngine;

public class Hurtbox : MonoBehaviour {

    public Unit owner;

    void OnTriggerEnter(Collider collider)
    {
        Hitbox hitBox = collider.GetComponent<Hitbox>();

        if (hitBox != null && hitBox.owner != owner)
        {
            owner.takeDamage();
        }
    }
}
