/*
 * Name:humanMovement
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose: controls human movement, life, help menu, possession of gun, and loss screen upon defeat
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humanMovement : MonoBehaviour
{
    //variable to object linkages
    public Text theScore;
    public GameObject lossScreen;
    public GameObject helpMenu;
    public GameObject bullets;
    public GameObject gun;
    public GameObject person;
    float time = 0;//time var
    int life = 5;//player health
    bool onGround = true;//check to see if player on ground or not
    // Start is called before the first frame update
    void Start()
    {
       //get player health to put in top left corner
        theScore.GetComponent<Text>();
        theScore.text = life.ToString();

        Invoke("timerhandler", 0.0f);//start loop
    }
   
    int control = 2;//limitation var
    bool isColliding = false;//var to check for repeated collision
    
    bool haveGun = false;//var to check for gun possession
    
    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;//time counter
        theScore.text = life.ToString();//update life counter
        isColliding = false;
        
        
        if(haveGun)//if gun possessed
        {
                gun.transform.position = new Vector3(person.transform.position.x-1.5f, person.transform.position.y, transform.position.z + 1);//gun goes with person
        }
        
        
        
        if (transform.position.z < -5.6)
        {
            transform.position = transform.position + new Vector3(0, 0, .1f);//manage z value
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))//if left arrow key pressed
        {

           
            if(control != 1)//if not on left lane
            {
                transform.Translate(-5, 0, 0);//move left
                control -= 1;//decrement movement limitation
            }          
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))//if right arrow key pressed
        {
            if(control != 3)//if not on right lane
            {
                transform.position = transform.position + new Vector3(5, 0, 0);//move right
                control += 1;//increment movement limitation
            }
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))//if up arrow key pressed
        {
            
            if (onGround == true)//person not in air
            {
                onGround = false;//person now in air
                this.gameObject.GetComponent<Rigidbody>().velocity = 12 * transform.localScale.y * this.gameObject.transform.up;//jump velocity
                
            }
        }
      
        if (Input.GetKeyDown(KeyCode.Escape) &&  !GameObject.Find("HelpMenu(Clone)"))// if press escape, spawn help menu; prevents duplicate menus
        {
            Time.timeScale = 0;//pause application
            var obj = Instantiate(helpMenu, new Vector3(0, 0, 0), Quaternion.identity);//spawn menu
        }

        if (Input.GetKeyDown(KeyCode.Space))//if press spacebar
        {
            if (haveGun)//if have gun
            {
                var obj = Instantiate(bullets, new Vector3(person.transform.position.x-1.5f, person.transform.position.y + .1f, person.transform.position.z + 2), Quaternion.Euler(90, 0, 0));//spawn bullet
            }
        }

    }

    void OnCollisionStay()//check if on ground
    {
        onGround = true;//if yes then is on ground
    }

    private void OnTriggerEnter(Collider other)//if trigger
    {
        if (isColliding)//dont count collision multple times
            return;
        isColliding = true;
        life = life - 1;//decrement health
        if(other.gameObject.name ==  "gun(Clone)")//if other is gun
        {
            haveGun = true;//gun in possession
            life++;//prevent decrement of health
        }
         if (life <= 0) Invoke("LossScreen", 0.0f);//if dead, loss screen
    }

    void timerhandler()//loop
    {
        if (time >= 50) Invoke("getGun", 0.0f);//time check for gun possession
        Invoke("timerhandler", 0.1f);//loop
    }
    void getGun()
    {
        haveGun = true;//gun in possession
    }

    void LossScreen()
    {
        
        Time.timeScale = 0;//pauses the application
        var obj = Instantiate(lossScreen, new Vector3(0,0,0), Quaternion.identity);//spawns loss screen ui
        
    }
}
