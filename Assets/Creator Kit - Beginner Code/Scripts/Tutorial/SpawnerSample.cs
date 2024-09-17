using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        int angle = 15;
        Vector3 spawnPosition = transform.position;

        
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;  // Rotate the direction vector x by 15 degrees around the y axis.
        spawnPosition = transform.position + direction * 2;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        angle = 15;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * 4;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        angle = 15;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * 6;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

