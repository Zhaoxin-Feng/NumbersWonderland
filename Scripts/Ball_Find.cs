using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Find : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //碰撞触发器检测函数 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //如果进入的物体标签为“Avatar” 则
        {
            UI_Mgr_02.Instance.SetIm_Catch(true);
            //显示面板 
            Destroy(gameObject);
            //销毁物体
        }
    }
}

