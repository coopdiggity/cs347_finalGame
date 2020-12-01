﻿
/*
 * Name:gunbehavior
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:controls movement and deletion of gun clones
 * 
*/using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * 25);//moving the obstacle
        if (this.transform.position.z <= -50)//limit for deletion
        {
            Destroy(this.gameObject);//delete 



        }
    }
    private void OnTriggerEnter(Collider other)//if collision
    {
        Destroy(this.gameObject);//delete
    }
}
