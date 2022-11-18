using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//引入命名空间

public class herotrans1 : MonoBehaviour
{
    public NavMeshAgent agent1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//鼠标左键被按下
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//定义射线
            RaycastHit hit;//保存碰撞信息
            if(Physics.Raycast(ray, out hit))
            {
               print(hit.point);//获取点击位置坐标
                agent1.SetDestination(hit.point);
            }
        }
       
    }
}
