using UnityEngine;

public class Boundary : BallworldObject
{
    public float weight = 1f;
    public bool mobile;

    void Start()
    {
        Rigidbody rigidBody = gameObject.AddComponent<Rigidbody>();
        rigidBody.useGravity = false;
        rigidBody.isKinematic = true;
    }

    void OnTriggerStay(Collider collider)
    {
        if (mobile)
        {
            if (collider.GetComponent<Boundary>() != null)
            {
                Boundary that = collider.GetComponent<Boundary>();

                if (that.GetComponent<BoxCollider>() != null)
                {
                    Vector2 size = GetComponent<BallworldObject>().size;
                    Vector3 left = (transform.right.normalized * (size.x / 2));
                    Vector3 right = (transform.right.normalized * (-size.x / 2));
                    Vector3 top = (transform.up.normalized * (size.y / 2));
                    Vector3 topLeft = left + top;
                    Vector3 topRight = top + right;
                    Vector3 relative = that.transform.position - transform.position;
                    float dotA = Vector3.Dot(topLeft, relative);
                    float dotB = Vector3.Dot(topRight, relative);
                    bool a = dotA > 0;
                    bool b = dotB > 0;

                    if (a && b)
                    {
                        transform.RotateAround(Vector3.zero, that.transform.right, -weight);
                    }
                    else if (a && !b)
                    {
                        transform.RotateAround(Vector3.zero, that.transform.up, weight);
                    }
                    else if (!a && b)
                    {
                        transform.RotateAround(Vector3.zero, that.transform.up, -weight);
                    }
                    else
                    {
                        transform.RotateAround(Vector3.zero, that.transform.right, weight);
                    }
                }
                else
                {
                    if (that.mobile)
                    {
                        // displace the weights and shift accordingly
                        transform.RotateAround(Vector3.zero, Vector3.Cross(collider.gameObject.transform.position, gameObject.transform.position), that.weight / weight);
                    }
                    else // I move the whole way
                    {
                        Debug.Log("sphere to sphere boundary no ");                                                  
                        transform.RotateAround(Vector3.zero, Vector3.Cross(collider.gameObject.transform.position, gameObject.transform.position), 1f);                                            
                    }                    
                }
            }
        }
    }
}