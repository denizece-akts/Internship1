using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] patterns;
    public float TimeBtwSpawn;
    public float StartSpawn;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, patterns.Length);
            Instantiate(patterns[rand], transform.position, Quaternion.identity);
            if(StartSpawn > minTime)
            {
                TimeBtwSpawn = StartSpawn;
            }
           
        }
        else
        {
            TimeBtwSpawn -=Time.deltaTime;
        }
    }
}
