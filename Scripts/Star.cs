using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;
using Vuforia;

public class Star : MonoBehaviour ,
IVirtualButtonEventHandler
{

    public GameObject astar;
    public ParticleSystem stars;




    // Use this for initialization
    void Start()
    {

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        Debug.Log("asdfasdf=========================================asd");
        // Get handle to the teapot object
        //		mBoll = transform.FindChild("teapot").gameObject;

    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonPressed=======::" + vb.VirtualButtonName);


    }


    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonReleased::" + vb.VirtualButtonName);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        astar.SetActive(true);
        stars.Play();

    }



    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {



    }
}

