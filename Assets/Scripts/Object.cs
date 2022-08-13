using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object 
{
    //public float moveSpeed { get; set; } PROP

    private int rotateSpeed;//propfull
    public bool isTrue { get; set; }//PROP
    
    public int RotateSpeed//propfull
    {
        get 
        {
            if (isTrue)
            {
                return rotateSpeed;
            }
            else
            {
                return 0;
            }
            
        }
        set { rotateSpeed = value; }
    }

}
