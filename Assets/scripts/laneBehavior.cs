/*
 * Name:laneBehavior
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:controls movement of obstacles and ends obstacles before spawning mummy
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laneBehavior : MonoBehaviour
{
    public GameObject Obstacle;//obstacle linkage
    
    float time = 0;//time var
    Object obj; //instantiation obj
    float spawnDelay = 2.0f;//base spawn delay
    // Start is called before the first frame update
    void Start()
    {
       
        spawnDelay = Random.Range(0.4f, 5.9f); //get spawn delay
        Invoke("SpawnObstacle", spawnDelay); //spawn new
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;//time counter
    }

    void SpawnObstacle() //create new dropts
    {
        var ObstacleClone = Instantiate(Obstacle, new Vector3(transform.position.x, 1, 100), Quaternion.identity);
        //ObstacleClone.GetComponent<Rigidbody>().velocity = -1 * transform.localScale.x * waterDropClone.transform.up;
        spawnDelay = Random.Range(0.4f, 3.5f); //get spawn time
        if (time >= 40)//at a certain time
        {
            Invoke("spawnMummy", 0.0f);//time check for mummy about to spawn
            
        }
        Invoke("SpawnObstacle", spawnDelay); //new drop
    }

    void spawnMummy()
    {
        
        CancelInvoke();//stop spawning obstacles
    }
}
