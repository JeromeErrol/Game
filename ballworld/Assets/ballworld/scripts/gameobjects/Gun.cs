using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public Bullet bullet;
    public Transform parentTransform;
    public float bulletSpeed = 2;
	
    public void fire()
    {
        Bullet bulletFired = (Bullet)GameObject.Instantiate(bullet, transform.position, transform.rotation, parentTransform);
        bulletFired.speed = bulletSpeed;
    }
}
