using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class TextDel : MonoBehaviour
{
    public Text Txt;


    public void OnMouseDown()
    {

        string textEd = Txt.text;


        int ind = textEd.Length - 1;

        textEd = textEd.Remove(ind);
        Txt.text = textEd;





    }
}
