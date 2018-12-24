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
    void OnEnable()
    {
        this.highLight = gameObject.GetComponent<HighlightObject>();
        if(this.highLight == null)
        {
            gameObject.AddComponent<HighlightObject>();
        }
        EasyTouch.On_SimpleTap += ShowMediaInfoPanel;
    }

    public void ShowMediaInfoPanel(Gesture gesture)
    {
		UIMgr.OpenPanel<UIMediaInfoPanel>(UILevel.Common, prefabName: "UIMediaInfoPanel");
		UIMgr.GetPanel<UIMediaInfoPanel> ();
		QUIManager.Instance.HideUI(this.name);

    }

    public void ShowHighLight(Gesture gesture)
    {
        this.highLight.SwithHightlight(true);
    }




}
