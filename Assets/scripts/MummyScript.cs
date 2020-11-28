using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyScript : MonoBehaviour
{
    // Start is called before the first frame update
    int k;
    float l;
    public GameObject poison;//poison ball ovj
    
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
        if (k == 1) this.transform.position = new Vector3(5, 1, 70);// right lane
        else if (k == 2) this.transform.position = new Vector3(0, 1, 70);// mid lane
        else if (k == 3) this.transform.position = new Vector3(-5, 1, 70);//left lane
        var obj = Instantiate(poison, this.transform.position, Quaternion.identity);//spawn projectile
        if(this.transform.position== new Vector3(5, 1, 70)) obj = Instantiate(poison, new Vector3(0, 1, 70), Quaternion.identity);//if right spawn another mid
        else if (this.transform.position == new Vector3(-5, 1, 70)) obj = Instantiate(poison, new Vector3(0, 1, 70), Quaternion.identity);//if left spawn another mid
        else if (this.transform.position == new Vector3(0, 1, 70) && l >0.5f) obj = Instantiate(poison, new Vector3(5, 1, 70), Quaternion.identity);//if mid spawn left or right
        else if (this.transform.position == new Vector3(0, 1, 70) && l < 0.5f) obj = Instantiate(poison, new Vector3(-5, 1, 70), Quaternion.identity);//if mid spawn left or right
        Invoke("timerHandler", 0.5f);

    }
}
