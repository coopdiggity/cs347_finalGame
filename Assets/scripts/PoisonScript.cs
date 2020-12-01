/*
 * Name: PoisonScript
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:controls movement and deletion of poison projectiles
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * 50);//movement speed of obj
        if (transform.position.z <= -50)//if hit certain coordinate
        {
            Destroy(this.gameObject);//delete
        }
    }

    private void OnTriggerEnter(Collider other)//if collide
    {
        Destroy(this.gameObject);//delete
    }
}
