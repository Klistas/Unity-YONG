using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliInput : MonoBehaviour
{
   //public float X { get; private set; }
   //public float Y { get; private set; }

    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public bool OnButton { get; private set; }

    // Update is called once per frame
    void Update()
    {

     Up = Down = Right = Left = false;
   
    Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
    Down = Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S);
    Left = Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A);
    Right = Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D);
        if(Input.GetKeyDown(KeyCode.R))
        {
            OnButton = !OnButton;
        }
   
  
    }
}
