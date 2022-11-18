using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class lizi : MonoBehaviour

{
    public GameObject num;




    void Start()
    {

        num.SetActive(true);

    }
    public void OnButtonPressed()
    {
       num.SetActive(false);
    }
        
    
}
