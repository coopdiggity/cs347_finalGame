/*
 * Name:RestartBtnScript
 * Members:Nathaniel Branham, Cooper Case, Xander Voigt
 * Purpose:unload and reload scene and then resume
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.UnloadSceneAsync("SampleScene");//unload scene
        SceneManager.LoadScene("SampleScene");//reload scene
        Time.timeScale = 1;//resume 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
