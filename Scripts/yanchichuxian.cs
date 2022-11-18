using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class yanchichuxian : MonoBehaviour
    
{
    public GameObject suanzhu;

    
  
       
        void Start()
        {
            suanzhu.SetActive(false);
           
        Invoke("A", 7.0f);
        }

        void A()
        {

            suanzhu.SetActive(true);
           
        }
    
}

   