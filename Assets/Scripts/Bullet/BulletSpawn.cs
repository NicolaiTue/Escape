using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public float StartSpawnRate ;
    float SpawnRate;
    public Transform Firepoint;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRate = StartSpawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnRate <= 0)
        {
            Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
            SpawnRate = StartSpawnRate;
        }
        else
        {
            SpawnRate -= Time.deltaTime;
        }
    }
}
