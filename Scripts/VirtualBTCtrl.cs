using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;


public class VirtualBTCtrl : MonoBehaviour,
IVirtualButtonEventHandler
{

    public GameObject mBoll;
    public GameObject suanpan;
    public GameObject suanzhu;
    public GameObject bangbangtang;
    public ParticleSystem lizi;
   
  

    // Use this for initialization
    void Start()
    {
        suanpan.SetActive(false);
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

        if (mBoll.activeSelf)
        {
            mBoll.SetActive(false);
        }
        else
        {
            mBoll.SetActive(true);
        }
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
       
        suanpan.SetActive(true);
        lizi.Play(); 
        Destroy(suanzhu);
       
        Invoke("A", 3.50f);

    }

    void A()
    {
        bangbangtang.SetActive(true);
        Destroy(suanpan);
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        gameObject.SetActive(true);
       
       
    }
}
