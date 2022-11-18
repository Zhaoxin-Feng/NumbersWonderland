using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bianzi : MonoBehaviour {

    public GameObject Tx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "one")
        { Tx.SetActive(true); }
    }
    
    }

