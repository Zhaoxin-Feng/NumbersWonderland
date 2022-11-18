using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {
    public GameObject chick;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    private bool condition = false;
    void Update()
    {
        if (!condition)
        {
            Vector3 dir = new Vector3(0, 1, 0);
            chick.transform.Rotate(dir, 90);
            condition = true;
        }
    }
}
