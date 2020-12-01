using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.UnloadSceneAsync("SampleScene");
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
