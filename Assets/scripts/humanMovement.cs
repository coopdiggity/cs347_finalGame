using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int control = 2;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -5.6)
        {
            transform.position = transform.position + new Vector3(0, 0, .1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            //-2.9, 2.17, 7.17
            //transform.position = transform.position + new Vector3(-4, 0, 0);
            if(control != 1)
            {
                transform.Translate(-5, 0, 0);
                control -= 1;
            }          
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(control != 3)
            {
                transform.position = transform.position + new Vector3(5, 0, 0);
                control += 1;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 2.5f, 0);

        }
    }
}
