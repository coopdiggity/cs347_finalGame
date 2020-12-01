/*
 * Name:ContinueBtnScript
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:resumes game and removes helpMenu
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject helpMenu;//helpmenu
    public void Start()
    {
        helpMenu=GameObject.Find("HelpMenu(Clone)");//link with game bj
        Time.timeScale = 1;//resume game
        Destroy(helpMenu);//remove help menu
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
