using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUi : Basescreen
{
    public Button backBtn;
    public Button basicBtn;
    public Button bankBtn;
    public Button statBtn;
    public Button kycBtn;

    public void Start()
    {
        backBtn.onClick.AddListener(OnClickBack);
        bankBtn.onClick.AddListener(OnClickProfileBank);
        basicBtn.onClick.AddListener(OnClickProfileBasic);
        statBtn.onClick.AddListener(OnClickProfileStat);
        kycBtn.onClick.AddListener(OnClickProfileKyc);
    }
    public void OnClickBack()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Home);
    }
    public void OnClickProfileBank()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Bank);
    }
    public void OnClickProfileBasic()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Basic);
    }
    public void OnClickProfileStat()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Stat);
    }
    public void OnClickProfileKyc()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.KYC);
    }
}
