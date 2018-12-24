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
	public class UIMediaInfoPanelData : UIPanelData
	{
		// TODO: Query Mgr's Data
	}

	public partial class UIMediaInfoPanel : UIPanel
	{
		UIMediaInfoPanelData mData = null;
		protected override void InitUI(IUIData uiData = null)
		{
			mData = uiData as UIMediaInfoPanelData ?? new UIMediaInfoPanelData();
			//please add init code here
		}

		protected override void ProcessMsg (int eventId,QMsg msg)
		{
			throw new System.NotImplementedException ();
		}

		protected override void RegisterUIEvent()
		{
			BackBtn.onClick.AddListener (()=>{
				
			});

			DetailBtn.onClick.AddListener (()=>{
				
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
		}

		void ShowLog(string content)
		{
			Debug.Log("[ UIMediaInfoPanel:]" + content);
		}

		public void ShowMediaInfo(MediaItemInfo info){
			if (info != null) {
				MediaTypeValue.text = info.iMediaType.ToString();
				MediaFormatValue.text = info.sMediaSize;
				MediaLocationValue.text = info.sMediaLocation;
				MediaNumberValue.text = info.sMediaNumber;
			} else
				Debug.Log ("mediainfo is null ... ");
		}
	}
}