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

        Invoke("timerhandler", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
       
    }
    void timerhandler()
    {
        if (time >= 10) Invoke("spawnMummy", 0.0f);//time check for mummy
        Invoke("timerhandler", 0.1f);
    }

    void spawnMummy()
    {
        CancelInvoke();
        obj = Instantiate(mummy, new Vector3(0, -0.5f, 41), Quaternion.identity); // at a set time summon the mummy\
        
    }
}
