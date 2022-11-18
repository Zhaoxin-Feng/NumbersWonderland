using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class two: MonoBehaviour
{
    public GameObject Tx;
    public GameObject yidong;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "two")
        {
            Destroy(gameObject);
            Tx.SetActive(true);
        }
    }
}


