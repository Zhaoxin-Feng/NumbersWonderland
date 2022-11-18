using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class figer : MonoBehaviour {
    public GameObject finger;


    // Use this for initialization
    void Start () {
        Invoke("appear", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void appear()
    {
        finger.SetActive(true);
    }
}
