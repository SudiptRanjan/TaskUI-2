using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TablelistUI : Basescreen
{
    public Button backBtn;
    public Button playButton;
    public Button NoButton;

    public void Start()
    {
        backBtn.onClick.AddListener(OnClickBack);
        playButton.onClick.AddListener(OnClickPlay);
        //NoButton.onClick.AddListener(OnClickPlay);
        NoButton.onClick.AddListener(OnClickNo);
    }
    public void OnClickBack()
        {
            ScreenManager.instance.SwitchScreen(ScreenType.Home);
        }
    public void OnClickPlay()
    {
        ScreenManager.instance.PopupEnable();
    }
    public void OnClickNo()
    {
        ScreenManager.instance.PopupDisable();
    }



}
