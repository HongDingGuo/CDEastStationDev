using DG.Tweening;
using HedgehogTeam.EasyTouch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class MediaItem : MonoBehaviour {

	public SpriteRenderer srAdpicture;
    private HighlightObject highLight;
    private MediaItemInfo Info;
    void OnEnable()
    {
        this.highLight = gameObject.GetComponent<HighlightObject>();
        if(this.highLight == null)
        {
            gameObject.AddComponent<HighlightObject>();
            gameObject.GetComponent<HighlightObject>().SwithHightlight(false);
        }
        EasyTouch.On_SimpleTap += ShowMediaInfoPanel;
    }

    public void ShowMediaInfoPanel(Gesture gesture)
    {
		UIMgr.OpenPanel<UIMediaInfoPanel>(UILevel.Common, prefabName: "UIMediaInfoPanel");
		UIMgr.GetPanel<UIMediaInfoPanel> ().ShowMediaInfo(this.Info);
		QUIManager.Instance.HideUI(this.name);

    }

    /// <summary>
    /// 实例化Item
    /// </summary>
    /// <param name="info"></param>
    public void InitItem(MediaItemInfo info)
    {
        if(info != null)
        {
            this.Info = info;
        }
        else
        {
            Debug.LogError("info is null ...");
        }
    }


    public void ShowHighLight(Gesture gesture)
    {
        this.highLight.SwithHightlight(true);
    }




}
