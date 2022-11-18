using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{

   
    public GameObject[] Balls;
    //储存算盘预制体
    

    void Awake()
    {
        Balls = Resources.LoadAll<GameObject>("Suanpan");
        //加载所有的算盘预制体
    }

    // Use this for initialization
    void Start()
    {
            InsBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

  

    //生成算盘
    private void InsBall()
    {
        int _ballIndex = Random.Range(0, Balls.Length);
        //从算盘总数中获取一个随机的序号
        GameObject _ball = Instantiate(Balls[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //根据随机序号在数组中取对应的预制体进行生成
        _ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //设置算盘的角度
        _ball.AddComponent<Rigidbody>();
        //增加刚体组件
        _ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //冻结刚体上的所有物理变换效果
        _ball.AddComponent<MoveEffect>();
        _ball.AddComponent<Ball_Find>();


    }

    
   
}
