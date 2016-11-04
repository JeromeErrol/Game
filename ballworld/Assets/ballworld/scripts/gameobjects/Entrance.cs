using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    public string scene;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<Player>() != null)
        {
            SceneManager.LoadScene(scene);
        }
    }
}