using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject PanelInfo;
    public GameObject PanelInfo2;
    public GameObject PanelInfo3;
    public GameObject PanelInfo4;

    public void OpenPanel()
    {
        if(PanelInfo != null){
            bool isActive = PanelInfo.activeSelf;
            PanelInfo.SetActive(!isActive);
        }
    }

    public void OpenPanel2()
    {
        if(PanelInfo2 != null){
            bool isActive = PanelInfo2.activeSelf;
            PanelInfo2.SetActive(!isActive);
        }
    }

    public void OpenPanel3()
    {
        if(PanelInfo3 != null){
            bool isActive = PanelInfo3.activeSelf;
            PanelInfo3.SetActive(!isActive);
        }
    }
    
    public void OpenPanel4()
    {
        if(PanelInfo4 != null){
            bool isActive = PanelInfo4.activeSelf;
            PanelInfo4.SetActive(!isActive);
        }
    }

}
