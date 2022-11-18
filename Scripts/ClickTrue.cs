using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTrue : MonoBehaviour
{
    public GameObject truebtn;
    public GameObject falsebtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        truebtn.SetActive(true);
        falsebtn.SetActive(false);

    }
}
