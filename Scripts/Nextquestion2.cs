﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nextquestion2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClick3);

    }
    void ButtonClick3()
    {
        SceneManager.LoadScene("practice3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
