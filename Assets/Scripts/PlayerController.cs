using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float LeftBoundary;

    public float RightBoundary;

    public float MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MyPos = transform.position;
        if(Input.GetKey(KeyCode.A))
        {
            MyPos.x -= MovementSpeed;
            Debug.Log("Move Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            MyPos.x += MovementSpeed;
            Debug.Log("Move Right");
        }

        if(MyPos.x < LeftBoundary)
            MyPos.x = LeftBoundary;
        if(MyPos.x > RightBoundary)
            MyPos.x = RightBoundary;
        
        transform.position = MyPos;

    }
}