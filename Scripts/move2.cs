using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{

    private float radian = 0;
    //起始的弧度

    private float perRad = 0.03f;
    //弧度的变化值
    private float add = 0f;
    //储存位移的偏移量
    private Vector3 posOri;
    //储存算盘的最初坐标


    // Use this for initialization
    void Start()
    {
        posOri = transform.position;
        //把物体最初的坐标记录下来
    }

    // Update is called once per frame
    void Update()
    {
        radian += perRad;
        //弧度不断的增加
        add = Mathf.Sin(radian);
        //得出偏移值
        transform.position = posOri + new Vector3(0, add * 0.4f, 0);
        //让物体浮动起来

    }
}

