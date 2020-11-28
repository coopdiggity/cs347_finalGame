using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humanMovement : MonoBehaviour
{
    public Text theScore;
    int life = 3;
    // Start is called before the first frame update
    void Start()
    {
       
        theScore.GetComponent<Text>();
        theScore.text = life.ToString();
    }
   
    int control = 2;

    // Update is called once per frame
    void Update()
    {
        theScore.text = life.ToString();
        if (life == 0) Invoke("LossScreen", 0.0f);
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
    private void OnTriggerEnter(Collider other)
    {
        life = life - 1;
    }

    void LossScreen()
    {
        //create loss screen here that allows restart or quit
    }
}
