using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2 : MonoBehaviour
{
    public GameObject pos1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Move", 15);
    }
    public void Move()
    {
        transform.position = Vector3.Lerp(transform.position, pos1.transform.position, 0.4f * Time.deltaTime);
    }
    public void Stop()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
    }
}
