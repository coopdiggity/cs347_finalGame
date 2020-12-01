using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laneBehavior : MonoBehaviour
{
    public GameObject Obstacle;
    
    float time = 0;
    Object obj; //instantiation obj
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
        time = time + Time.deltaTime;
    }

    void SpawnObstacle() //create new dropts
    {
        var ObstacleClone = Instantiate(Obstacle, new Vector3(transform.position.x, 1, 100), Quaternion.identity);
        //ObstacleClone.GetComponent<Rigidbody>().velocity = -1 * transform.localScale.x * waterDropClone.transform.up;
        spawnDelay = Random.Range(0.4f, 3.5f); //get spawn time
        if (time >= 40)
        {
            Invoke("spawnMummy", 0.0f);//time check for mummy
            
        }
        Invoke("SpawnObstacle", spawnDelay); //new drop
    }

    void spawnMummy()
    {
        
        CancelInvoke();
    }
}
