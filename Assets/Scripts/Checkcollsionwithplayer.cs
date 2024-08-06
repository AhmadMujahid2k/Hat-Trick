using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkcollsionwithplayer : MonoBehaviour
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
        if(collisionInfo.gameObject.name == "Player")
        {
          Debug.Log("HIT");
         Destroy(this.gameObject,3);

        collisionInfo.otherCollider.gameObject.GetComponent<Exploder>().startExplosion = true;
        collisionInfo.gameObject.GetComponent<PlayerRecord>().lives--;
        }
     
    }
}
