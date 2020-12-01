﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humanMovement : MonoBehaviour
{
    public Text theScore;
    public GameObject lossScreen;
    public GameObject helpMenu;
    public GameObject bullets;
    GameObject hm;
    int life = 20;
    bool onGround = true;
    // Start is called before the first frame update
    void Start()
    {
       
        theScore.GetComponent<Text>();
        theScore.text = life.ToString();
    }
   
    int control = 2;
    bool isColliding = false;

    // Update is called once per frame
    void Update()
    {

        isColliding = false;
        theScore.text = life.ToString();

        int bulletMove = 0;

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
                bulletMove -= 5;
                control -= 1;
            }          
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(control != 3)
            {
                transform.position = transform.position + new Vector3(5, 0, 0);
                control += 1;
                bulletMove += 5;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.position = transform.position + new Vector3(0, 2.5f, 0);
            if (onGround == true)
            {
                onGround = false;
                this.gameObject.GetComponent<Rigidbody>().velocity = 12 * transform.localScale.y * this.gameObject.transform.up;
                
            }
        }
      
        if (Input.GetKeyDown(KeyCode.Escape) &&  !GameObject.Find("HelpMenu(Clone)"))// if press escape, spawn help menu; prevents duplicate menus
        {
            Time.timeScale = 0;//pause application
            var obj = Instantiate(helpMenu, new Vector3(0, 0, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Space))     
        {
            if(control == 1)
            {
                var obj = Instantiate(bullets, new Vector3(-5, 1, -3), Quaternion.Euler(90, 0, 0));
            }
            if (control == 2)
            {
                var obj = Instantiate(bullets, new Vector3(0, 1, -3), Quaternion.Euler(90, 0, 0));
            }
            if (control == 3)
            {
                var obj = Instantiate(bullets, new Vector3(5, 1, -3), Quaternion.Euler(90, 0, 0));
            }


        }




    }

    void OnCollisionStay()
    {
        onGround = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (isColliding)
            return;
        isColliding = true;
        life = life - 1;
         if (life <= 0) Invoke("LossScreen", 0.0f);
    }

    void LossScreen()
    {
        
        Time.timeScale = 0;//pauses the application
        var obj = Instantiate(lossScreen, new Vector3(0,0,0), Quaternion.identity);//spawns loss screen ui
        
    }
}
