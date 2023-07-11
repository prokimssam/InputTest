using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DDRTest : MonoBehaviour
{
    public SpriteRenderer SelectImages;
    public SpriteRenderer StartImages;
    
    public SpriteRenderer LeftImage;
    public SpriteRenderer DownImage;
    public SpriteRenderer RightImage;
    public SpriteRenderer UpImage;
    
    public SpriteRenderer UpLeftImage;
    public SpriteRenderer UpRightImage;
    public SpriteRenderer DownLeftImage;
    public SpriteRenderer DownRightImage;
    
    private void Awake()
    {
        SelectImages.color = Color.clear;
        StartImages.color = Color.clear;
        
        LeftImage.color = Color.clear;
        DownImage.color = Color.clear;
        RightImage.color = Color.clear;
        UpImage.color = Color.clear;
        
        UpLeftImage.color = Color.clear;
        UpRightImage.color = Color.clear;
        DownLeftImage.color = Color.clear;
        DownRightImage.color = Color.clear;
    }

    private void Update()
    {
        SelectImages.color = DDR.instance.select.isPressed ? Color.yellow : Color.clear;
        StartImages.color = DDR.instance.start.isPressed ? Color.yellow : Color.clear;
        
        LeftImage.color = DDR.instance.left.isPressed ? Color.yellow : Color.clear;
        DownImage.color = DDR.instance.down.isPressed ? Color.yellow : Color.clear;
        RightImage.color = DDR.instance.right.isPressed ? Color.yellow : Color.clear;
        UpImage.color = DDR.instance.up.isPressed ? Color.yellow : Color.clear;
        
        UpLeftImage.color = DDR.instance.upLeft.isPressed ? Color.yellow : Color.clear;
        UpRightImage.color = DDR.instance.upRight.isPressed ? Color.yellow : Color.clear;
        DownLeftImage.color = DDR.instance.downLeft.isPressed ? Color.yellow : Color.clear;
        DownRightImage.color = DDR.instance.downRight.isPressed ? Color.yellow : Color.clear;
    }
}

