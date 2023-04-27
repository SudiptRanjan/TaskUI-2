using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablelistUI : Basescreen
{
    
        public void OnClickBack()
        {
            ScreenManager.instance.SwitchScreen(ScreenType.Home);
        }
    

}
