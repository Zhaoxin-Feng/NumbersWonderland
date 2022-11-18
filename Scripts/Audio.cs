using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio: MonoBehaviour
{
    //定义声音组件
    public AudioSource audio01;
    public AudioSource audio02;
    public AudioSource audio03;
    public AudioSource audio04;
    public AudioSource audio05;
    public AudioSource audio06;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    public void audioPlay01()
    {
        audio01.Play();//播放音乐01
        audio02.Stop();//暂停音乐02
        audio03.Stop();//暂停音乐03
        audio04.Stop();
        audio05.Stop();
        audio06.Stop();
        one.SetActive(true);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
    }

    public void audioPlay02()
    {
        audio01.Stop();
        audio02.Play();
        audio03.Stop();
        audio04.Stop();
        audio05.Stop();
        audio06.Stop();
        one.SetActive(false);
        two.SetActive(true);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
    }

    public void audioPlay03()
    {
        audio01.Stop();
        audio02.Stop();
        audio03.Play();
        audio04.Stop();
        audio05.Stop();
        audio06.Stop();
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(true);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
    }
    public void audioPlay04()
    {
        audio01.Stop();
        audio02.Stop();
        audio03.Stop();
        audio04.Play();
        audio05.Stop();
        audio06.Stop();
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(true);
        five.SetActive(false);
        six.SetActive(false);
    }
    public void audioPlay05()
    {
        audio01.Stop();
        audio02.Stop();
        audio03.Stop();
        audio04.Stop();
        audio05.Play();
        audio06.Stop();
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(true);
        six.SetActive(false);
    }
    public void audioPlay06()
    {
        audio01.Stop();
        audio02.Stop();
        audio03.Stop();
        audio04.Stop();
        audio05.Stop();
        audio06.Play();
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(true);
    }
}
