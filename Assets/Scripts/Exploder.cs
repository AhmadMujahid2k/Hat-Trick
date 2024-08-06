using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exploder : MonoBehaviour
{

    public Sprite[] explosionSprites;
    public SpriteRenderer explosionSite;
    public int FramesPerSprite;
    public int FrameCounter;
    public int spritecount;
    private int spriteIndex;

    public bool startExplosion;

    // Start is called before the first frame update
    void Start()
    {
        FrameCounter=0;
        spritecount = explosionSprites.Length;
        spriteIndex =-1;
        startExplosion = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if(!startExplosion)
        {
            return;
        }
        FrameCounter++;

        if (FrameCounter >= FramesPerSprite)
        {
            FrameCounter =0;
            spriteIndex++;
            if (spriteIndex >=  spritecount)
            {
                spriteIndex=0;
            }
            explosionSite.sprite = explosionSprites[spriteIndex];
        }
    }
}
