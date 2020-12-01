/*
 * Name:BackgroundBehavior
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose: spawns background pyramids at random intervals
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public GameObject pyramid;//pyramid linkage
    Object obj; //instantiation obj
    float spawnDelay = 2.0f;//initial spawn delays
    float spawnDelay2 = 2.0f;
    float spawnDelay3 = 2.0f;
    float spawnDelay4 = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

        spawnDelay = Random.Range(0.4f, 5.9f); //get spawn delay
        spawnDelay2 = Random.Range(0.4f, 5.9f); //get spawn delay
        spawnDelay3 = Random.Range(0.4f, 5.9f); //get spawn delay
        spawnDelay4 = Random.Range(0.4f, 5.9f); //get spawn delay
        Invoke("SpawnPyramid", spawnDelay); //spawn new
        Invoke("SpawnPyramid2", spawnDelay2);
        Invoke("SpawnPyramid3", spawnDelay3); //spawn new
        Invoke("SpawnPyramid4", spawnDelay4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPyramid() //create new dropts
    {
        var PyramidClone = Instantiate(pyramid, new Vector3(transform.position.x + 50, 1, 300), Quaternion.identity);//spawn pyramid
        
        spawnDelay = Random.Range(5.0f, 15.0f); //get spawn time
        
        Invoke("SpawnPyramid", spawnDelay); //new drop
    }
    void SpawnPyramid2() //create new dropts
    {
        var PyramidClone = Instantiate(pyramid, new Vector3(transform.position.x - 50, 1, 300), Quaternion.identity);//spawn pyramid

        spawnDelay2 = Random.Range(6.0f, 16.0f); //get spawn time

        Invoke("SpawnPyramid2", spawnDelay2); //new drop
    }
    void SpawnPyramid3() //create new dropts
    {
        var PyramidClone = Instantiate(pyramid, new Vector3(transform.position.x + 300, 1, 300), Quaternion.identity);//spawn pyramid

        spawnDelay3 = Random.Range(5.0f, 15.0f); //get spawn time

        Invoke("SpawnPyramid3", spawnDelay3); //new drop
    }
    void SpawnPyramid4() //create new dropts
    {
        var PyramidClone = Instantiate(pyramid, new Vector3(transform.position.x + 350, 1, 300), Quaternion.identity);//spawn pyramid

        spawnDelay4 = Random.Range(6.0f, 16.0f); //get spawn time

        Invoke("SpawnPyramid4", spawnDelay4); //new drop
    }
}