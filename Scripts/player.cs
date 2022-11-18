using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//引入命名空间

public class player : MonoBehaviour
{
   
    public Animator anim;//获取到人物的动画器组件
    public GameObject hero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        Rigidbody rig = GetComponent<Rigidbody>();
        anim.SetFloat("speed", rig.velocity.magnitude);//获取人物的速度大小，并赋值给speed
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can")
        {
            Debug.Log("销毁" + other.gameObject.name);
            Destroy(other.gameObject); 
            //记得触发检测中，两个物体都必须要加collider，至少要有一个物体加rigidbody
        }
    }
}
