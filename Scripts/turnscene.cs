using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class turnscene : MonoBehaviour
{
    public int number;
    public void OnStartGame()
    {
        //Application.LoadLevel(SceneNumber); //Unity4.6及之前版本的写法
        //int number = Random.Range(1, 3);
        SceneManager.LoadScene(number);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
