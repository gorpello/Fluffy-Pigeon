using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 0;
    private float timer = 50;


    // Start is called before the first frame update
    void Start()
    {
        //spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
            float lowerPoint = transform.position.y - heightOffset;
            float highterPoint = transform.position.y + heightOffset;

            Vector3 randomPosition = new Vector3(transform.position.x,
                                                Random.Range(lowerPoint, highterPoint), 
                                                0);

            Instantiate(pipe, randomPosition, transform.rotation);
    }
}
