/*
 * Name:pyramidBehavior
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:move the pyramids and delete them is they go past a certain point
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidBehavior : MonoBehaviour
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
}
