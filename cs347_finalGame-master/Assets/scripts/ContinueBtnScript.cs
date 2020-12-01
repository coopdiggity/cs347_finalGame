using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject helpMenu;
    public void Start()
    {
        helpMenu=GameObject.Find("HelpMenu(Clone)");
        Time.timeScale = 1;
        Destroy(helpMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
