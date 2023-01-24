using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CloudSpawn : MonoBehaviour
{
    public GameObject Clouds;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public float widthOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnClouds();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnClouds();
            timer = 0;
        }


    }
    void spawnClouds()
    {
        float lowesPoint = transform.position.y - heightOffset;
        float highesPoint = transform.position.y + heightOffset;
       
        Instantiate(Clouds, new Vector3(transform.position.x, Random.Range(lowesPoint, highesPoint), 0), transform.rotation);
    }
}


