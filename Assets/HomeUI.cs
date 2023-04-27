using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : Basescreen
{
    public Button practiceBtn;
    public Button profileBtn;
    public Button touchArea;
    public Canvas touchCanvas;
   
    public void Start()
    {
        practiceBtn.onClick.AddListener(OnClickCash);
        profileBtn.onClick.AddListener(OnClickProfile);       
    }
    public void OnClickCash()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Tablelist);
    }

    public void OnClickTouchArea()
    {
        touchCanvas.enabled = true;
    }

    public void OnClickProfile()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Basic);
    }
}
