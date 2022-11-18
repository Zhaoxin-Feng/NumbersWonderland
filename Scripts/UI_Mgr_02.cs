using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Mgr_02 : MonoBehaviour
{

  
    public GameObject Im_AR;
    //储存显示面板
    public static UI_Mgr_02 Instance;
    //申请静态公有脚本类变量

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
       
    }

    //设置捕捉面板的激活状态
    public void SetIm_Catch(bool bl)
    {
        Im_AR.SetActive(bl);
        //通过调用函数时传入的bool类型参数bl来设置面板状态
    }

    //跳转AR场景的按钮函数
    public void Btn_GoARScn()
    {
        SceneManager.LoadScene("AR_Scn");
    }

    
}
