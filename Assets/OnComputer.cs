using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnComputer : MonoBehaviour
{
    public GameObject Anim;
    public float timer;
    public GameObject Screnn;
    public Variables Var;
    public bool need;
    public void OnMouseDown()
    {
       
        if(Screnn.activeInHierarchy == false)
            {
             Screnn.SetActive(true);
             Anim.SetActive(true);
            need = true;
             

         } else {
                Screnn.SetActive(false);
                Var.Can = false;
        }
        
    }

    void Update()
    {
                if (need)
                {
                    timer = timer + Time.deltaTime;
                    if (timer >=4)
                    {
                        Anim.SetActive(false);
                        
                        timer = 0;
                        need = false;
                        Var.Can = true;
                    }
                }

    }
}
