using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class OpenCloseComp : MonoBehaviour
{
    public bool Close;
    public bool Open;
    public int rot;
    void Update()
    {
        if (Open == true)
        {
          
            Opened();
          
        }
        if (Close == true)
        {
            Closed();


        }
    }

   
    public void OnMouseDown()
    {

        if (rot > 90)
        {
            Open = true;
            Close = false;
              
        }
        else if(rot < 90)

        {
           
            Open = false;
            Close = true;
          
        }






    }
    void Closed()
    {
        Quaternion newRotation = Quaternion.AngleAxis(105, Vector3.right);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, .0025f);
        rot = 91;
    }
    void Opened()
    {
        Quaternion newRotation = Quaternion.AngleAxis(0, Vector3.left);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, .0025f);
        rot = 0;
    }
}
