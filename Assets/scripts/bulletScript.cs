using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * Time.deltaTime * 100); //moving the bullet
        if (this.transform.position.z >= 100)//limit for deletion
        {
            Destroy(this.gameObject);//delete 



        }
    }
}
