using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class TabScrip : MonoBehaviour
{
   
    public Variables Var;
    public void OnMouseDown()
    {
        if (Var.Tab == false)
        {
            Var.Tab = true;
        }
        else
        {
            Var.Tab = false;
        }





    }
}
