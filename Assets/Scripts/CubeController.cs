using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //public int number { get; set; } = 5; PROP
    Object myobject = new Object();

    private void Start()
    {
        // print(number); PROP
        // myobject.moveSpeed = 5; PROP

        myobject.RotateSpeed = 40; //propfull
        myobject.isTrue = true;  //PROP
    }

    private void Update()
    {
        //CubeMove();
        CubeRotate(); 
    }

    private void CubeMove()
    {
        //transform.Translate(0, 0, myobject.moveSpeed * Time.deltaTime); PROP
    }

    private void CubeRotate()
    {
        transform.Rotate(myobject.RotateSpeed * Time.deltaTime, 0, 0); //propfull
    }
}
