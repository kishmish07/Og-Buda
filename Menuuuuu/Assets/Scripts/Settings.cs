using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

public class Settings : MonoBehaviour
{
    public GameObject x1,x2,x3,x4,x5,x6,x7,x8,x9,x10;
    
    int total = 1;
    public void Start()
    {
        Deactivate(x1,x2,x3,x4,x5,x6,x7,x8,x9, x10);
        if (total % 10 == 1)
        {
            Activate(x1);
        }
        if (total % 10 == 2)
        {
            Activate(x2);
        }
        if (total % 10 == 3)
        {
            Activate(x3);
        }
        if (total % 10 == 4)
        {
            Activate(x4);
        }
        if (total % 10 == 5)
        {
            Activate(x5);
        }
        if (total % 10 == 6)
        {
            Activate(x6);
        }
        if (total % 10 == 7)
        {
            Activate(x7);
        }
        if (total % 10 == 8)
        {
            Activate(x8);
        }
        if (total % 10  == 9)
        {
            Activate(x9);
        }
        if (total % 10 == 0)
        {
            Activate(x10);
        }

    }
    void Deactivate(GameObject x1, GameObject x2, GameObject x3, GameObject x4, GameObject x5, GameObject x6, GameObject x7, GameObject x8, GameObject x9, GameObject x10)
    {
        x1.SetActive(false);
        x2.SetActive(false);
        x3.SetActive(false);
        x4.SetActive(false);
        x5.SetActive(false);
        x6.SetActive(false);
        x7.SetActive(false);
        x8.SetActive(false);
        x9.SetActive(false);
        x10.SetActive(false);

    }
    void Activate(GameObject x1)
    {
        x1.SetActive(true);
    }
    public void Total()
    {
        total++;
    }
    public void Text()
    {

    }
}
    
