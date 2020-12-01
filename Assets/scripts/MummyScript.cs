using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MummyScript : MonoBehaviour
{
    // Start is called before the first frame update
    int k;
    float l;
    int health = 50;
    public GameObject poison;//poison ball ovj
    public GameObject victoryScreen;
    void Start()
    {
        Invoke("timerHandler", 0.0f);//call fcn
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void timerHandler ()
    {
        l = Random.value;
        k = (int)Random.Range(1.0f, 3.99f); //between 1 and 3 truncated
        if (k == 1) this.transform.position = new Vector3(5, -0.5f, 41);// right lane
        else if (k == 2) this.transform.position = new Vector3(0, -0.5f, 41);// mid lane
        else if (k == 3) this.transform.position = new Vector3(-5, -0.5f, 41);//left lane
        var obj = Instantiate(poison, new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z), Quaternion.identity);//spawn projectile
        if(this.transform.position== new Vector3(5, -0.5f, 41)) obj = Instantiate(poison, new Vector3(0, 1, 41), Quaternion.identity);//if right spawn another mid
        else if (this.transform.position == new Vector3(-5, -0.5f, 41)) obj = Instantiate(poison, new Vector3(0, 1, 41), Quaternion.identity);//if left spawn another mid
        else if (this.transform.position == new Vector3(0, -0.5f, 41) && l >0.5f) obj = Instantiate(poison, new Vector3(5, 1, 41), Quaternion.identity);//if mid spawn left or right
        else if (this.transform.position == new Vector3(0, -0.5f, 41) && l < 0.5f) obj = Instantiate(poison, new Vector3(-5, 1, 41), Quaternion.identity);//if mid spawn left or right
        Invoke("timerHandler", 0.5f);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other);
        health = health - 1;
        if (health <= 0) Invoke("VictoryScreen", 0.0f);
    }

    void VictoryScreen()
    {
        
        Time.timeScale=0;//pauses the application
        var obj = Instantiate(victoryScreen, new Vector3(0, 0, 0), Quaternion.identity);
       
    }
}

