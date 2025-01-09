using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class WriteMesage : MonoBehaviour
{
    public Text Txt;
    public string Buk;
    public string SmailBuk;
    public Variables Var;
    public void OnMouseDown()
    {
        if (Var.Can == true)
        {
            if (Var.Tab == false)
            {
                Txt.text = Txt.text + Buk;
            }
            else
            {
                if (SmailBuk != "")
                {
                    Txt.text = Txt.text + SmailBuk;
                }
                else
                {
                    Txt.text = Txt.text + Buk;
                }
            }
        }
      





    }
}
