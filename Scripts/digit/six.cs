using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class six: MonoBehaviour
{
    public GameObject Tx;
    public GameObject yidong;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "six")
        {
            Destroy(gameObject);
            Tx.SetActive(true);
        }
    }
}


