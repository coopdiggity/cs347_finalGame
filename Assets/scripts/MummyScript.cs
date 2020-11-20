using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyScript : MonoBehaviour
{
    GameObject mummy;
    GameObject MuProj;
    Vector3 right = new Vector3(5.0f, 0.01f, 300.0f);
    Vector3 mid = new Vector3(0.0f, 0.01f, 300.0f);
    Vector3 left = new Vector3(-5.0f, 0.01f, 300.0f);
    // Start is called before the first frame update
    void Start()
    {
        mummy = GameObject.Find("Mummy");
        MuProj = GameObject.Find("Mummy Projectile");
        Invoke("TimerHandler", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimerHandler ()
    {
       
        int dir = Random.Range(1, 3);
        if (dir == 1) mummy.transform.position = right;
        else if (dir == 2) mummy.transform.position = mid;
        else if (dir == 3) mummy.transform.position = left;
        var proj = Instantiate(MuProj, new Vector3(mummy.transform.position.x, mummy.transform.position.y, mummy.transform.position.z-1), Quaternion.identity);
        Invoke("TimerHandler", 1.0f);
    }
}
