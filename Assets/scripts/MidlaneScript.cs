using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidlaneScript : MonoBehaviour
{
  
    public GameObject Obstacle;
    public GameObject mummy; //mummy obj
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

    }

    void SpawnObstacle() //create new dropts
    {
        var ObstacleClone = Instantiate(Obstacle, new Vector3(transform.position.x, 1, 300), Quaternion.identity);
        //ObstacleClone.GetComponent<Rigidbody>().velocity = -1 * transform.localScale.x * waterDropClone.transform.up;
        spawnDelay = Random.Range(0.4f, 5.9f); //get spawn time
        if (Time.time >= 40) Invoke("spawnMummy", 0.0f);//time check for mummy
        Invoke("SpawnObstacle", spawnDelay); //new drop
    }
    void spawnMummy()
    {
        obj = Instantiate(mummy, new Vector3(0, 1, 70), Quaternion.identity); // at a set time summon the mummy\
        CancelInvoke();
    }
}
