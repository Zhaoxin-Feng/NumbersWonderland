using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonTest : MonoBehaviour, IVirtualButtonEventHandler
{  //实现IVirtualButtonEventHandler接口，该接口包含OnButtonPressed和OnButtonReleased两个方法

    private  AudioSource A;
    private ParticleSystem yinfu;

    // Use this for initialization
    void Start()
    {

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();   //获取VirtualButton Behaviour组件
        for (int i = 0; i < vbs.Length; ++i)
        {     //遍历所有组件
            vbs[i].RegisterEventHandler(this);    //对该脚本进行注册
        }//

        

    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "showCube":
                A.Play ();
                break;
            case "showSphere":
                yinfu .Play();
                break;
        }
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
       
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }
}