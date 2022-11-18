using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowH2 : MonoBehaviour
{
    
    public GameObject flametest;
    public GameObject lighttest;
    public ParticleSystem particlemist;
    public ParticleSystem particleblue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void lowH()
    {
        if (flametest.activeInHierarchy)
        {
            Invoke("littlefire", 5.0f);
        }
        else if (lighttest.activeInHierarchy)
        {
            particlemist.Play();
        }
        // Destroy(suanzhu);
        // Invoke("A", 3.50f);
    }
    void littlefire()
    {
       
        particlemist.Play();
        particleblue.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
