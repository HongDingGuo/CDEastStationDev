using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediaSelectPanel : MonoBehaviour
{

    #region Public

    public Button btn_Dengxaing;
    public Button btn_Baozhu;
    public Button btn_Diaoqi;
    public Button btn_Bolizhao;
    public Button btn_Dianti;
    public Button btn_Led;
    public Button btn_Shuapin;
    public Button btn_Bolitie;

    public Button btn_backBtn;
    #endregion

    public void ClickBackBtn()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        btn_Dengxaing.onClick.AddListener(ClickDengxaing);
        btn_Baozhu.onClick.AddListener(ClickBaozhu);
        btn_Diaoqi.onClick.AddListener(ClickDiaoqi);
        btn_Bolizhao.onClick.AddListener(ClickBolizhao);
        btn_Dianti.onClick.AddListener(ClickDianti);
        btn_Led.onClick.AddListener(ClickLed);
        btn_Shuapin.onClick.AddListener(ClickShuapin);
        btn_Bolitie.onClick.AddListener(ClickBolitie);
    }

    public void ClickDengxaing()
    {
        
    }

    public void ClickBaozhu()
    {

    }

    public void ClickDiaoqi()
    {

    }

    public void ClickBolizhao()
    {

    }

    public void ClickDianti()
    {

    }

    public void ClickLed()
    {

    }

    public void ClickShuapin()
    {

    }

    public void ClickBolitie()
    {

    }
    
}
