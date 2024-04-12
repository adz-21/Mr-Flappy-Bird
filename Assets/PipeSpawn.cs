using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float spawnRate = 3;
    float height = 10; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime; // to keep things consistent across different computers
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float upper = transform.position.y + height;
        float lower = transform.position.y - height;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lower,upper),0), transform.rotation);
    }
}
