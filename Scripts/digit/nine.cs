using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class nine: MonoBehaviour
{
    public GameObject Tx;
    public GameObject yidong;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "nine")
        {
            Destroy(gameObject);
            Tx.SetActive(true);
        }
    }
}


