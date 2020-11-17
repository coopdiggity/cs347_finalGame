using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laneBehavior : MonoBehaviour
{
    public GameObject Obstacle;

    float spawnDelay = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = Random.Range(0.4f, 5.9f); //get spawn delay
        Invoke("SpawnObstacle", spawnDelay); //spawn new
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() //create new dropts
    {
        var ObstacleClone = Instantiate(Obstacle, new Vector3(transform.position.x, 1, 300), Quaternion.identity);
        //ObstacleClone.GetComponent<Rigidbody>().velocity = -1 * transform.localScale.x * waterDropClone.transform.up;
        spawnDelay = Random.Range(0.4f, 5.9f); //get spawn time
        Invoke("SpawnObstacle", spawnDelay); //new drop
    }
}
