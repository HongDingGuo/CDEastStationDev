using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMainPanel : MonoBehaviour
{
    #region Public

    public Button btn_HouCheCeng;
    public Button btn_ChuFaCeng;
    public Button btn_DiTieCeng;
    public Button btn_Media;
    public Button btn_ZiChan;
    public Button btn_Quit;
    public Button btn_Diaoqi;
    public Button btn_Dengxiang;
    public Button btn_Baozhu;

    public Button btn_hcdgc;
    public Button btn_hczj;
    public Button btn_hcxgc;

    public Button btn_A2;
    public Button btn_A13;
    public Button btn_A26;

    public Button btn_dtdgc;
    public Button btn_dtzj;
    public Button btn_dtxgc;

    public Transform tf_player;
    
    public GameObject obj_player;
    public GameObject obj_MediaSelect;
    public GameObject obj_zichanSelect;
    public GameObject obj_houcheceng;
    public GameObject obj_chufaceng;
    public GameObject obj_ditieceng;

    public UICanvas canvas;
    public MediaInfoPanel infoPanel;
    #endregion

    
    public void ClickHouChe()
    {
        obj_houcheceng.SetActive(!obj_houcheceng.activeSelf);
        obj_chufaceng.SetActive(false);
        obj_ditieceng.SetActive(false);
        obj_zichanSelect.SetActive(false);
        obj_MediaSelect.SetActive(false);
    }
    
    public void ClickChufa()
    {
        obj_chufaceng.SetActive(!obj_chufaceng.activeSelf);
        obj_houcheceng.SetActive(false);
        obj_ditieceng.SetActive(false);
        obj_zichanSelect.SetActive(false);
        obj_MediaSelect.SetActive(false);
    }
    
    public void ClickDitie()
    {
        obj_ditieceng.SetActive(!obj_ditieceng.activeSelf);
        obj_chufaceng.SetActive(false);
        obj_houcheceng.SetActive(false);
        obj_zichanSelect.SetActive(false);
        obj_MediaSelect.SetActive(false);
    }
    
    public void ClickMedia()
    {
        obj_MediaSelect.SetActive(!obj_MediaSelect.activeSelf);
        obj_zichanSelect.SetActive(false);
        obj_chufaceng.SetActive(false);
        obj_houcheceng.SetActive(false);
        obj_ditieceng.SetActive(false);
    }
    
    public void ClickZichan()
    {
        obj_zichanSelect.SetActive(!obj_zichanSelect.activeSelf);
        obj_MediaSelect.SetActive(false);
        obj_chufaceng.SetActive(false);
        obj_houcheceng.SetActive(false);
        obj_ditieceng.SetActive(false);
    }

    /// <summary>
    /// 候车层东广场方向
    /// </summary>
    public void ClickHCDGC()
    {
        obj_player.transform.position = new Vector3(20, 11, -140);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// 候车层中间
    /// </summary>
    public void ClickHCZJ()
    {
        obj_player.transform.position = new Vector3(20, 11, 0);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// 候车层西广场方向
    /// </summary>
    public void ClickHCXGC()
    {
        obj_player.transform.position = new Vector3(20, 11, 125);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
    }

    /// <summary>
    /// 出发层A2/B2方向
    /// </summary>
    public void ClickA2()
    {
        obj_player.transform.position = new Vector3(16, 1, 112);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
    }

    /// <summary>
    /// 出发层A13/B13方向
    /// </summary>
    public void ClickA13()
    {
        obj_player.transform.position = new Vector3(16, 1, 5);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 270, 0));
    }

    /// <summary>
    /// 出发层A26/B26方向
    /// </summary>
    public void ClickA26()
    {
        obj_player.transform.position = new Vector3(16, 1, -125);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// 地铁层东广场方向
    /// </summary>
    public void ClickDTDGC()
    {
        obj_player.transform.position = new Vector3(20, -9, -176);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// 地铁层中间
    /// </summary>
    public void ClickDTZJ()
    {
        obj_player.transform.position = new Vector3(20, -9, 10);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// 地铁层西广场方向
    /// </summary>
    public void ClickDTXGC()
    {
        obj_player.transform.position = new Vector3(20, -9, 187);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
    }
    

    public void ClickDiaoqi()
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.ShowDiaoqi();
        gameObject.SetActive(false);
    }

    public void ClickDengxiang()
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.ShowDengxiang();
        gameObject.SetActive(false);
    }

    public void ClickBaozhu()
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.ShowBaozhu();
        gameObject.SetActive(false);
    }

    public void ClickLED()
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.ShowLED();
        gameObject.SetActive(false);
    }

    public void ClickDianZi()
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.ShowDZXXP();
        gameObject.SetActive(false);
    }


    /// <summary>
    /// 点击返回按钮
    /// </summary>
    public void ClickQuit()
    {
        canvas.ShowStartPanel();
    }

}
