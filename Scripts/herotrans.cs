using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//引入命名空间

public class herotrans : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;//获取到人物的动画器组件
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
                agent.SetDestination(hit.point);
            }
        }
        anim.SetFloat("speed", agent.velocity.magnitude);//获取人物的速度大小，并赋值给speed
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can")
        {
            //Debug.Log("销毁" + other.gameObject.name);
            Destroy(other.gameObject);
            //记得触发检测中，两个物体都必须要加collider，至少要有一个物体加rigidbody
        }
    }
}
