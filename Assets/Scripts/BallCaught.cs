using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BallCaught : MonoBehaviour
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
       Debug.Log("contact points: " + collisionInfo.contactCount);
       ContactPoint2D[] contactsAt = new ContactPoint2D[collisionInfo.contactCount];
       collisionInfo.GetContacts(contactsAt);
       foreach(ContactPoint2D cont in contactsAt)
       {
           Debug.Log(cont.point);
           Debug.Log("Other collider type : " + cont.collider.GetType());
           if (cont.collider.GetType() == typeof(EdgeCollider2D))
           {
                cont.collider.gameObject.GetComponent<PlayerRecord>().score++;
               Destroy(gameObject);
           }
       } 
    }
    
}
