using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public Vector3 ballstartappearing;
    public int framRate;
    private int FrameSinceLastSpawn;
    public GameObject BallPrefab;
    public int SpawnPointXMin;
    public int SpawnPointXMax;
    private System.Random rndGen; 

    // Start is called before the first frame update
    void Start()
    {
        FrameSinceLastSpawn = 0;
        rndGen  = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
       FrameSinceLastSpawn++;
        if (FrameSinceLastSpawn >= framRate)
        {
            Debug.Log("Spawn..." + FrameSinceLastSpawn);
            FrameSinceLastSpawn = 0;
            ballstartappearing.x = GetRandom();
            Instantiate(BallPrefab , ballstartappearing , Quaternion.identity);
        }
    }
    int GetRandom()
    {
       return rndGen.Next(SpawnPointXMin,SpawnPointXMax);
    }
    
}
