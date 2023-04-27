using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeUI : Basescreen
{
    
    public void OnClickCash()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Tablelist);
    }
}
