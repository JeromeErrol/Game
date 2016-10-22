using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

    public int framesBetweenSpawn = 60;
    private int currentFrame = 0;
    public GameObject spawnType;

    public int enemiesPerWave = 10;
    public int enemiesSpawnedThisWave = 0;
	
	void Update () {
        if (enemiesSpawnedThisWave < enemiesPerWave)
        {
            if (currentFrame++ > framesBetweenSpawn)
            {
                currentFrame = 0;
                Quaternion rotation = transform.rotation;
                Vector3 angle = rotation.eulerAngles;
                angle.z = Random.Range(0, 360f);
                rotation.eulerAngles = angle;
                GameObject.Instantiate(spawnType, transform.position, rotation, GameObject.FindGameObjectWithTag("Respawn").transform);
                enemiesSpawnedThisWave++;
            }
        }
	}
}
