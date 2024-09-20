using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting;




public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int generate_potion_count = 4;
    public  LootAngle myloot_angle = new(15);

    void Start()
    {
        for (int i = 0; i < generate_potion_count; i++)
        {
            SpawnPotion(myloot_angle.NextAngle());
        }
        
        
    }
    void SpawnPotion(int angle)
    {
        Vector3 spawnPosition = transform.position;
        Vector3 direct = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direct * 2;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
    //void OnMouseDown()
    //{
    //    SpawnPotion(myloot_angle.NextAngle());
    //    print("Spawned a potion");
    //}
}

public class LootAngle
{
    int angle;
    int step;

    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }
    public int NextAngle()
    {
        int currentAngel = angle;
        angle = Helpers.WrapAngle(angle + step);
        return currentAngel;
    }
}

