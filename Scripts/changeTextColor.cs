using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTextColor : MonoBehaviour
{
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeText()
    {
        myText.GetComponent<Text>().text = "我被点中了！";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
