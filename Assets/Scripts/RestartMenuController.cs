using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       public void btnRestart_click()
    {
        Debug.Log("Unload This Sence and load Start.");
       // SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadSceneAsync(2);
    }
}
