using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shanxian : MonoBehaviour
{

    
    
        public Space m_RotateSpace;
        public float m_RotateSpeed = 20f;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up * m_RotateSpeed * Time.deltaTime, m_RotateSpace);
        }
    
}
