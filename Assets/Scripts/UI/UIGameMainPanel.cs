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
		public const int HCCID = 1;
		public const int CFCID = 2;
		public const int DTCID = 3;
		public const int MediaSelect = 4;
		public const int AssetSelect = 5;
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
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
            });
			A26Btn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});
			A2Btn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});

			dtdgcBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});
			dtxgcBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});
			dtzjBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});

			hcdgcBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});
			hcxgcBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});
			hczjBtn.onClick.AddListener (()=>{
				CDGameManager.Instance.SetPlayerPosition(Vector3.zero,Vector3.zero);
			});

			MediaBtn.onClick.AddListener (()=>{
				if(MediaSelectScrollView.gameObject.activeSelf){
					MediaSelectScrollView.gameObject.SetActive(false);
					MediaLowerSelect.gameObject.SetActive(false);
				}
				else{
					ShowSelectContent(MediaSelect);
				}
			});

			//地铁层
			SubwayFloorBtn.onClick.AddListener (()=>{
				if(DitiecengSelect.gameObject.activeSelf){
					DitiecengSelect.gameObject.SetActive(false);
				}else{
					ShowSelectContent(DTCID);	
				}
			});
			//候车层
			WaitingFloorBtn.onClick.AddListener (()=>{
				if(HouchecengSelect.gameObject.activeSelf){
					HouchecengSelect.gameObject.SetActive(false);
				}
				else{
					ShowSelectContent(HCCID);
				}
			});
			//出发层
			GoFloorBtn.onClick.AddListener (()=>{
				if(ChufacengSelect.gameObject.activeSelf){
					ChufacengSelect.gameObject.SetActive(false);
				}
				else{
					ShowSelectContent(CFCID);
				}
			});

			//搜索按钮
			ClickSeachBtn.onClick.AddListener(()=>{
				MediaInfoManager.Instance.DoSearchItem(SeachInputField.text);
				SeachInputField.text = "";
			});
			//点击退出
			ExitBtn.onClick.AddListener (()=>{
				UIMgr.OpenPanel<UIStartPanel>(UILevel.Common, prefabName: "UIStartPanel");
				CDGameManager.Instance.ShowCamera();
				QUIManager.Instance.HideUI(this.name);

			});


		}

		private void ShowSelectContent(int Id){
			MediaSelectScrollView.gameObject.SetActive (false);
			ZichanSelectScrollView.gameObject.SetActive (false);
			ChufacengSelect.gameObject.SetActive (false);
			DitiecengSelect.gameObject.SetActive (false);
			HouchecengSelect.gameObject.SetActive (false);
			MediaLowerSelect.gameObject.SetActive (false);
			switch (Id) {
			case HCCID:
				HouchecengSelect.gameObject.SetActive (true);
				break;
			case CFCID:
				ChufacengSelect.gameObject.SetActive (true);
				break;
			case DTCID:
				DitiecengSelect.gameObject.SetActive (true);
				break;
			case MediaSelect:
				MediaSelectScrollView.gameObject.SetActive (true);
				break;
			case AssetSelect:
				ZichanSelectScrollView.gameObject.SetActive (true);
				break;
			default:
				break;
			}
		}


		#region 继承的方法
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
		#endregion

	}
}