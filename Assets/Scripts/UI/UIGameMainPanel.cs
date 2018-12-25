/****************************************************************************
 * 2018.12 78S8S5TBTCBBJNU
 ****************************************************************************/
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	public class UIGameMainPanelData : UIPanelData
	{
		// TODO: Query Mgr's Data
	}

	public partial class UIGameMainPanel : UIPanel
	{
		protected override void InitUI(IUIData uiData = null)
		{
			mData = uiData as UIGameMainPanelData ?? new UIGameMainPanelData();
			//please add init code here
		}

		protected override void ProcessMsg (int eventId,QMsg msg)
		{
			throw new System.NotImplementedException ();
		}

		protected override void RegisterUIEvent()
		{
            A13Btn.onClick.AddListener(()=> {

            });
		}

		protected override void OnShow()
		{
			base.OnShow();
		}

		protected override void OnHide()
		{
			base.OnHide();
		}

		protected override void OnClose()
		{
			base.OnClose();
            UnRegisterAllEvent();
		}

		void ShowLog(string content)
		{
			Debug.Log("[ UIGameMainPanel:]" + content);
		}

		UIGameMainPanelData mData = null;
	}
}