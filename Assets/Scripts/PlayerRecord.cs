using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerRecord : MonoBehaviour
{
    // Start is called before the first frame update

    public int lives;
    public int score;
    public Text scoretxt;
    public Text livestxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = score.ToString();
        livestxt.text = lives.ToString();

         if (this.lives<=0)
        {
            SceneManager.LoadSceneAsync(0);
            //SceneManager.UnloadSceneAsync(1);     
        }

    }
}
