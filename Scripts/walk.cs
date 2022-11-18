
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{

    public Transform start;
    public Transform end;
    public GameObject chick;
    public Animation chickanim;
    public float speed;
    void Start()
    {
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(start.position, end.position, speed * Time.deltaTime);
       
    }

    
    
}
