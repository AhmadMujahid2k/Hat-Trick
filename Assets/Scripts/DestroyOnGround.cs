using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
       Debug.Log("contact points: " + collisionInfo.gameObject);
      if(collisionInfo.gameObject.name == "Grass_0")
       {
           Destroy(gameObject);
       }
    }

}
