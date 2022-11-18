using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerctrl : MonoBehaviour
{
    public Animator ani;
    public Animation anim;
    public float speed = 100f;
    public GameObject Player;
    

    void Start()
    {
      
    }


    void Update()
    {
        

    }
    public void foward()
    {
        this.ani.SetTrigger("walk");
        Vector3 dir = new Vector3(0, 0, 1);
        Player.transform.Translate(dir * Time.deltaTime * speed);
       }
    public void Right()
    {
        this.ani.SetTrigger("walk");
        Vector3 dir = new Vector3(0, 1, 0);
        Player.transform.Rotate(dir, 90);
       
    }
    public void Left()
    {
        this.ani.SetTrigger("walk");
        Vector3 dir = new Vector3(0, 1, 0);
        Player.transform.Rotate(dir, 270);

    }
    public void Jump()
    {
        this.ani.SetTrigger("jump");
    }
   
    public void stop()
    {
        ani.speed = 0;
    }
}

