using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stringlisten : MonoBehaviour
{
    public GameObject zhengque;
    public GameObject cuowu;
    public GameObject answer;
   
    // Start is called before the first frame update
    void Start()
    {
        

    }
    void Update()
    {
        InputField inputfinger = answer.transform.GetComponent<InputField>();
        if (inputfinger.text == ("3"))
        {
            zhengque.SetActive(true);
            cuowu.SetActive(false);
        }
        if (inputfinger.text != ("3"))
        {
            cuowu.SetActive(true);
            zhengque.SetActive(false);
        }
        if (inputfinger.text == (""))
        {
            cuowu.SetActive(false);
            zhengque.SetActive(false);
        }
    }

   

}

