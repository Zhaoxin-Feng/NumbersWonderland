using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class go : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public GameObject player;
    public bool 按下判断;
    public void OnPointerDown(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
        按下判断 = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        按下判断 = false;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (按下判断)
        {
            player.transform.Translate( 0, 0, 100 * Time.deltaTime);
            print("已经按下");
        }
    }
}
