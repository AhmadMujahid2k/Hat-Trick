using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BombCaught : MonoBehaviour
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
           Debug.Log("My Collider: " + cont.otherCollider.gameObject.name);
           Debug.Log("Other collider type : " + cont.collider.GetType());
           if (cont.collider.GetType() == typeof(EdgeCollider2D))
           {
               
               collisionInfo.otherCollider.gameObject.GetComponent<Exploder>().startExplosion = true;
               collisionInfo.gameObject.GetComponent<PlayerRecord>().lives--;
               Destroy(this.gameObject,1.5f);
           }
       } 
    }
}
