using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basescreen : MonoBehaviour
{
    public enum ScreenType
    {
        Home,Tablelist
    }

    public ScreenType screenType;
    public Canvas canvas;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
}
