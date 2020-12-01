/*
 * Name: MidlaneScript
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose: summon the mummy after a set amount of time
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidlaneScript : MonoBehaviour
{
  
   
    public GameObject mummy; //mummy obj
    float time = 0;
    Object obj; //instantiation obj
    // Start is called before the first frame update
    void Start()
    {

        Invoke("timerhandler", 0.0f);//start loop
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;//update time passed
       
    }
    void timerhandler()
    {
        if (time >= 57) Invoke("spawnMummy", 0.0f);//time check for mummy
        Invoke("timerhandler", 0.1f);//loop
    }

    void spawnMummy()
    {
        CancelInvoke();//end loop
        obj = Instantiate(mummy, new Vector3(0, -0.5f, 41), Quaternion.identity); //  summon the mummy
        
    }
}
