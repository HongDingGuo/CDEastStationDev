using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediaInfoPanel : MonoBehaviour {

    #region Public
    public UICanvas uicanvas;

    public Text t_MediaTypeValue;
    public Text t_MediaNumberValue;
    public Text t_AssetsNumberValue;
    public Text t_MediaLocationValue;
    public Text t_OperationEntitiesValue;
    public Text t_AgentCompanyValue;
    public Text t_PublishContentValue;
    public Text t_StartTimeValue;
    public Text t_EndTimeValue;

    public Transform tf_Rotater;

    public Button btn_BackBtn;
    public Button btn_CloseDetailBtn;
    public Button btn_DetailBtn;

    public GameObject obj_diaoqi;
    public GameObject obj_baozhu;
    public GameObject obj_dengxiang;
    public GameObject obj_ADDetail;
    public GameObject obj_LED;
    public GameObject obj_DZXXP;
    public GameMainPanel mainPanel;
    #endregion

    /// <summary>
    /// 关闭UI
    /// </summary>
    public void ClickBackBtn()
    {
        gameObject.SetActive(false);
        mainPanel.gameObject.SetActive(true);
    }

    public void CloseDetail()
    {
        obj_ADDetail.SetActive(false);
    }

    public void ShowDetail()
    {
        obj_ADDetail.SetActive(true);
    }

    /// <summary>
    /// 展示媒体信息
    /// </summary>
    /// <param name="objName"></param>
    //public void ShowMediaInfo(string objName)
    //{
    //   Dictionary<string, MediaInfoItem> tempDic = MediaInfoManager.GetInstance.Dic_MediaInfo;
    //    if(tempDic !=null && tempDic.ContainsKey(objName))
    //    {
    //        MediaInfoItem tempItem = tempDic[objName];
    //        t_MediaTypeValue.text = tempItem.str_MediaTypeValue;
    //        t_MediaNumberValue.text = tempItem.str_MediaNumberValue;
    //        t_AssetsNumberValue.text = tempItem.str_AssetsNumberValue;
    //        t_WidthValue.text = tempItem.str_WidthValue;
    //        t_LengthValue.text = tempItem.str_LengthValue;
    //        t_AreaValue.text = tempItem.str_AreaValue;
    //        t_MediaLocationValue.text = tempItem.str_MediaLocationValue;
    //        t_OperationEntitiesValue.text = tempItem.str_OperationEntitiesValue;
    //        t_AgentCompanyValue.text = tempItem.str_AgentCompanyValue;
    //        t_PublishContentValue.text = tempItem.str_PublishContentValue;
    //        t_StartTimeValue.text = tempItem.str_StartTimeValue;
    //        t_EndTimeValue.text = tempItem.str_EndTimeValue;
    //    }
    //}

    private void DestoryRotater()
    {
        if (tf_Rotater.childCount > 0)
        {
            int childCount = tf_Rotater.childCount;
            for (int i = 0; i < childCount; ++i)
            {
                Destroy(tf_Rotater.GetChild(i).gameObject);
            }
        }
    }

    public void ShowDiaoqi()
    {
        t_MediaTypeValue.text = "吊旗（双面）";
        t_MediaNumberValue.text = "CCM-CDD-H-3-01";
        t_AssetsNumberValue.text = "待定";
        t_MediaLocationValue.text = "成都东站候车层西广场";
        t_OperationEntitiesValue.text = "成铁传媒";
        t_AgentCompanyValue.text = "南京永达";
        t_PublishContentValue.text = "巴洛克";
        t_StartTimeValue.text = "2016-11-10";
        t_EndTimeValue.text = "2018-08-10";
        DestoryRotater();
        GameObject.Instantiate(obj_diaoqi, tf_Rotater.position, Quaternion.identity, tf_Rotater);
        tf_Rotater.localPosition = new Vector3(0, -0.3f, 1.3f);
    }

    public void ShowDengxiang()
    {
        t_MediaTypeValue.text = "灯箱";
        t_MediaNumberValue.text = "CCM-CDD-O-1g-03";
        t_AssetsNumberValue.text = "待定";
        t_MediaLocationValue.text = "成都东站出站层西广场南墙";
        t_OperationEntitiesValue.text = "成铁传媒";
        t_AgentCompanyValue.text = "南京永达";
        t_PublishContentValue.text = "红蜻蜓";
        t_StartTimeValue.text = "2018-10-22";
        t_EndTimeValue.text = "2019-4-22";
        DestoryRotater();
        GameObject.Instantiate(obj_dengxiang, tf_Rotater.position, Quaternion.identity, tf_Rotater);
        tf_Rotater.localPosition = new Vector3(0,0,1.3f);
        
    }

    public void ShowBaozhu()
    {
        t_MediaTypeValue.text = "包柱（三面）";
        t_MediaNumberValue.text = "CCM-CDD-H-1c-01";
        t_AssetsNumberValue.text = "待定";
        t_MediaLocationValue.text = "成都东站候车层西广场";
        t_OperationEntitiesValue.text = "成铁传媒";
        t_AgentCompanyValue.text = "南京永达";
        t_PublishContentValue.text = "索菲亚";
        t_StartTimeValue.text = "2017-01-10";
        t_EndTimeValue.text = "2018-06-30";
        DestoryRotater();
        GameObject.Instantiate(obj_baozhu, tf_Rotater.position, Quaternion.identity, tf_Rotater);
        tf_Rotater.localPosition = new Vector3(0, 0, 1.7f);
    }

    public void ShowLED()
    {
        t_MediaTypeValue.text = "LED全彩屏";
        t_MediaNumberValue.text = "CCM-CDD-H-2-05";
        t_AssetsNumberValue.text = "待定";
        t_MediaLocationValue.text = "成都东站西分流厅";
        t_OperationEntitiesValue.text = "成铁传媒";
        t_AgentCompanyValue.text = "南京永达";
        t_PublishContentValue.text = "北京现代、小郎酒、一汽大众";
        t_StartTimeValue.text = "2018-11-10";
        t_EndTimeValue.text = "2018-12-12";
        DestoryRotater();
        GameObject.Instantiate(obj_LED, tf_Rotater.position, Quaternion.identity, tf_Rotater);
        tf_Rotater.localPosition = new Vector3(0, 0, 4.0f);
    }

    public void ShowDZXXP()
    {
        t_MediaTypeValue.text = "电子信息屏";
        t_MediaNumberValue.text = "CCM-CDD-H-13-（01至24）";
        t_AssetsNumberValue.text = "待定";
        t_MediaLocationValue.text = "成都东站候车层B2检票口";
        t_OperationEntitiesValue.text = "成铁传媒";
        t_AgentCompanyValue.text = "北京航讯";
        t_PublishContentValue.text = "海信";
        t_StartTimeValue.text = "2018-11-9";
        t_EndTimeValue.text = "2018-12-12";
        DestoryRotater();
        GameObject.Instantiate(obj_DZXXP, tf_Rotater.position, Quaternion.identity, tf_Rotater);
        tf_Rotater.localPosition = new Vector3(0, 0, 4.5f);
    }
}
