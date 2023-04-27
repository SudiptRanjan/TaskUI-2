using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : Basescreen
{
    public Basescreen[] screens;
    public Basescreen currentScreen;
    public static ScreenManager instance;
    private void Awake()
    {
        instance = this;
        currentScreen.canvas.enabled = true;
    }

    public void  SwitchScreen(ScreenType screenType)
    {
        currentScreen.canvas.enabled = false;
        foreach (Basescreen baseScreen in screens)
        {
           if(baseScreen.screenType == screenType)
            {
                baseScreen.canvas.enabled = true;
                    currentScreen = baseScreen;
                    Debug.Log("loop failed");
                    break;
            }
        }
    }
}
