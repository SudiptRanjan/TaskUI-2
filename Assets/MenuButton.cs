using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Canvas bankCanvas;
    public Canvas basicCanvas;
    public Canvas statisticsCanvas;
    public Canvas kycCanvas;
    public Canvas homeCanvas;
    public Canvas sideCanvas;
    public Canvas tableListCanvas;
    public Canvas popCanvas;
    //private void Start()
    //{
    //    //bankButton = gameObject.GetComponent<Canvas>();
    //    //basicButton = gameObject.GetComponent<Canvas>();
    //    //statisticsButton = gameObject.GetComponent<Canvas>();
    //    //kycButton = gameObject.GetComponent<Canvas>();
    //}


    //public void Update()
    //{

    //}
    public void Profile_Onclick()
    {
        BankButton_OnClick();
        BasicButton_OnClick();
        StatisticsButton_OnClick();
        KYCButton_OnClick();
    }
    public void BankButton_OnClick()
    {
        
        if(bankCanvas.gameObject.activeInHierarchy==true)
        {
            bankCanvas.gameObject.SetActive(false);
            bankCanvas.enabled = false;
        }
        else
        {
            bankCanvas.gameObject.SetActive(true);
            bankCanvas.enabled = true;
        }
       
    }
    public void BasicButton_OnClick()
    {
        if (basicCanvas.gameObject.activeInHierarchy == true)
        {
            basicCanvas.gameObject.SetActive(false);
            basicCanvas.enabled = false;
        }
        else
        {
            basicCanvas.gameObject.SetActive(true);
            basicCanvas.enabled = true;
        }


    }

    public void StatisticsButton_OnClick()
    {
        if (statisticsCanvas.gameObject.activeInHierarchy == true)
        {
            statisticsCanvas.gameObject.SetActive(false);
            statisticsCanvas.enabled = false;
        }
        else
        {
            statisticsCanvas.gameObject.SetActive(true);
            statisticsCanvas.enabled = true;
        }

    }
    public void KYCButton_OnClick()
    {
        if (kycCanvas.gameObject.activeInHierarchy == true)
        {
            kycCanvas.gameObject.SetActive(false);
            kycCanvas.enabled = false;

        }
        else
        {
            kycCanvas.gameObject.SetActive(true);
            kycCanvas.enabled = true;
        }

    }
    public void HomeButton_OnClick()
    {
        if (homeCanvas.gameObject.activeInHierarchy == true)
        {
            homeCanvas.gameObject.SetActive(false);
            homeCanvas.enabled = false;

        }
        else
        {
            homeCanvas.gameObject.SetActive(true);
            homeCanvas.enabled = true;
        }

    }
    public void SideButton_OnClick()
    {
        if (sideCanvas.gameObject.activeInHierarchy == true)
        {
            sideCanvas.gameObject.SetActive(false);
            sideCanvas.enabled = false;

        }
        else
        {
            sideCanvas.gameObject.SetActive(true);
            sideCanvas.enabled = true;
        }

    }

    public void SideBarProfile_OnClick()
    {
        if (basicCanvas.gameObject.activeInHierarchy == true)
        {
            basicCanvas.gameObject.SetActive(false);
            basicCanvas.enabled = false;

        }
        else
        {
            basicCanvas.gameObject.SetActive(true);
            basicCanvas.enabled = true;
        }

    }

    public void SideBarTableList_OnClick()
    {
        if (tableListCanvas.gameObject.activeInHierarchy == true)
        {
            tableListCanvas.gameObject.SetActive(false);
            tableListCanvas.enabled = false;

        }
        else
        {
            tableListCanvas.gameObject.SetActive(true);
            tableListCanvas.enabled = true;
        }

    }

    public void PopUp_OnClick()
    {
        if (popCanvas.gameObject.activeInHierarchy == true)
        {
            popCanvas.gameObject.SetActive(false);
            popCanvas.enabled = false;

        }
        else
        {
            popCanvas.gameObject.SetActive(true);
            popCanvas.enabled = true;
        }

    }

    public void PopUpYesNo_OnClick()
    {
        if (tableListCanvas.gameObject.activeInHierarchy == true)
        {
            tableListCanvas.gameObject.SetActive(false);
            tableListCanvas.enabled = false;

        }
        else
        {
            tableListCanvas.gameObject.SetActive(true);
            tableListCanvas.enabled = true;
        }

    }




}
