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
	public class UIStartPanelData : UIPanelData
	{
		// TODO: Query Mgr's Data
	}

	public partial class UIStartPanel : UIPanel
	{
		protected override void InitUI(IUIData uiData = null)
		{
			mData = uiData as UIStartPanelData ?? new UIStartPanelData();
			//please add init code here
		}

		protected override void ProcessMsg (int eventId,QMsg msg)
		{
			throw new System.NotImplementedException ();
		}

		protected override void RegisterUIEvent()
		{
			ComfirmBtn.onClick.AddListener(() =>
				{
					CDGameManager.Instance.ShowCircleCamera();
				});
			EastBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
				UIMgr.OpenPanel<UIGameMainPanel>(UILevel.Common, prefabName: "UIGameMainPanel");
				QUIManager.Instance.HideUI(this.name);
			});

			SouthBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
				UIMgr.OpenPanel<UIGameMainPanel>(UILevel.Common, prefabName: "UIGameMainPanel");
				QUIManager.Instance.HideUI(this.name);
			});

			WestBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
				UIMgr.OpenPanel<UIGameMainPanel>(UILevel.Common, prefabName: "UIGameMainPanel");
				QUIManager.Instance.HideUI(this.name);
			});

			NorthBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
				UIMgr.OpenPanel<UIGameMainPanel>(UILevel.Common, prefabName: "UIGameMainPanel");
				QUIManager.Instance.HideUI(this.name);
			});

			QuitBtn.onClick.AddListener (()=>{
				QuitGame();
			});
		}

		private void QuitGame(){
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#elif UNITY_IOS||UNITY_ANDROID
			Application.Quit();
			#endif
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
			Debug.Log("[ UIStartPanel:]" + content);
		}

		UIStartPanelData mData = null;
	}
}