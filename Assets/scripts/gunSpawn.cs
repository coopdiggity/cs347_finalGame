using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSpawn : MonoBehaviour
{
    float time = 0;
    public GameObject gun;
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
        if (time >= 10) Invoke("spawnGuns", 0.0f);//time check for gun
        Invoke("timerhandler", 0.1f);
    }

    void spawnGuns()
    {
        CancelInvoke();
        var gunClone0 = Instantiate(gun, new Vector3(-5, 1, 100), Quaternion.identity);
        var gunClone1 = Instantiate(gun, new Vector3(0, 1, 100), Quaternion.identity);
        var gunClone2 = Instantiate(gun, new Vector3(5, 1, 100), Quaternion.identity);

        
        
    }
}
