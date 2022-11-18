using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject pos1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 10);
    }
    public void Move()
    {
        transform.position = Vector3.Lerp(transform.position, pos1.transform.position, speed * Time.deltaTime);
    }
    public void Stop()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
    }
}
