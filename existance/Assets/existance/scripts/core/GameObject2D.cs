using UnityEngine;
using System.Collections;

public class GameObject2D : MonoBehaviour {

    public Vector2 velocity;
    public Vector2 acceleration;

    public void FixedUpdate()
    {        
        velocity += acceleration;
        acceleration = Vector2.zero;
        move(velocity);
    }

    public void move(Vector2 velocity)
    {
       GetComponent<Rigidbody2D>().MovePosition(position + velocity * Time.fixedDeltaTime);
    }

    public float x
    {
        get
        {
            return transform.position.x;
        }
        set
        {
            Vector3 position = transform.position;
            position.x = value;
            transform.position = position;
        }
    }

    public float y
    {
        get
        {
            return transform.position.y;
        }
        set
        {
            Vector3 position = transform.position;
            position.y = value;
            transform.position = position;
        }
    }

    public float rotation
    {
        get
        {
            return transform.rotation.eulerAngles.z;
        }
        set
        {
            Vector3 eulerAngles = transform.rotation.eulerAngles;
            eulerAngles.z = value;
            Quaternion rotation = transform.rotation;
            rotation.eulerAngles = eulerAngles;
            transform.rotation = rotation;
        }
    }

    public Vector2 position
    {
        get
        {
            return new Vector2(x, y);
        }
        set
        {
            x = value.x;
            y = value.y;
        }
    }

    public void moveForward(float distance)
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * distance);
    }

    public void moveSideways(float distance)
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * distance);
    }  

    public void rotateTowards(Transform target, float speed) {  
        Vector3 _direction = (target.position - transform.position).normalized;
        Quaternion _lookRotation = Quaternion.LookRotation(_direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * speed);
    }

    public void lookAt(Vector2 target)
    {
        Vector2 diff = position - target;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    public void lookAt(Transform target)
    {
        Vector3 diff = target.position - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
