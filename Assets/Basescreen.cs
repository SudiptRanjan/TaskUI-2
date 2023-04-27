using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ScreenType
{
    Home, Tablelist, Bank, Basic, Stat, KYC, PopUp, Sidebar
}

public class Basescreen : MonoBehaviour
{
   
    public ScreenType screenType;
    [HideInInspector]
    public Canvas canvas;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
}
