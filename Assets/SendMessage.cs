using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class SendMessage : MonoBehaviour
{
    public Text Txt;
    public Text Nadpis;
    public GameObject Panel;
    public Text comp;
    public float timer;
    public bool Need;
    public Variables Var;

    public void OnMouseDown()
    {

        string textEd = "";
        comp.text = "Сообщение отправлено!!"; 
        Nadpis.text = "";
        Panel.SetActive(false);
        Txt.text = textEd;
        Need = true;
        Var.Can = false;
        timer = 0;
    }
     public void Button()
    {

        string textEd = "";
        comp.text = "Сообщение отправлено!!"; 
        Txt.text = textEd;
        Need = true;
        Var.Can = false;
        timer = 0;
    }
    void Update()

    {
        if (Need) { 
        timer = timer +Time.deltaTime;
        }
        if (timer >= 2)
        {
            comp.text = "";
            Nadpis.text = "Напиши Сообщение";
            Panel.SetActive(true);
            Need = false;
            Var.Can = true;
        }
       
    }
}