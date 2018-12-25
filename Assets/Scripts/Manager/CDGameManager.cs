using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class CDGameManager : MonoSingleton<CDGameManager> {


    public Transform tfDiaoQi;
    public Transform tfBaoZhu;
    public Transform tfBoLiZhaoDX;

	public GameObject objPlayer;
	public GameObject objJoyCanvas;
	public GameObject objRotateCamera;

    //public GameObject objDiaoQiPrefab;
    //public GameObject objBaoZhuPrefab;
    //public GameObject objBoLiZhaoDXPrefab;

	private void Awake()
	{
		UIMgr.OpenPanel<UIStartPanel>(prefabName: "UIStartPanel");
	}

    private void Start()
    {
        StartCoroutine(InitAllItems());
    }

    IEnumerator InitAllItems()
    {
        if(MediaInfoManager.Instance.DicDiaoQiInfo != null && MediaInfoManager.Instance.DicDiaoQiInfo.Count > 0)
        {
            Dictionary<string, MediaItemInfo> tempInfo = MediaInfoManager.Instance.DicDiaoQiInfo;
            foreach(string key in tempInfo.Keys)
            {
                GameObject tempObj = Instantiate(Resources.Load<GameObject>("Prefab"));
                MediaItem tempItem = tempObj.GetComponent<MediaItem>();
                if (tempItem == null)
                {
                    tempObj.AddComponent<MediaItem>();
					tempItem = tempObj.GetComponent<MediaItem>();
					tempItem.InitItem(tempInfo[key]);
					if(!MediaInfoManager.Instance.DicAllItem.ContainsKey(key))
						MediaInfoManager.Instance.DicAllItem.Add (key, tempItem);
                }
            }

        }
        if (MediaInfoManager.Instance.DicBaoZhuInfo != null && MediaInfoManager.Instance.DicBaoZhuInfo.Count > 0)
        {
			Dictionary<string, MediaItemInfo> tempInfo = MediaInfoManager.Instance.DicBaoZhuInfo;
			foreach(string key in tempInfo.Keys)
			{
				GameObject tempObj = Instantiate(Resources.Load<GameObject>("Prefab"));
				MediaItem tempItem = tempObj.GetComponent<MediaItem>();
				if (tempItem == null)
				{
					tempObj.AddComponent<MediaItem>();
					tempItem = tempObj.GetComponent<MediaItem>();
					tempItem.InitItem(tempInfo[key]);
					if(!MediaInfoManager.Instance.DicAllItem.ContainsKey(key))
						MediaInfoManager.Instance.DicAllItem.Add (key, tempItem);
				}
			}
        }
        if (MediaInfoManager.Instance.DicBoLiZhaoDXInfo != null && MediaInfoManager.Instance.DicBoLiZhaoDXInfo.Count > 0)
        {
			Dictionary<string, MediaItemInfo> tempInfo = MediaInfoManager.Instance.DicBoLiZhaoDXInfo;
			foreach(string key in tempInfo.Keys)
			{
				GameObject tempObj = Instantiate(Resources.Load<GameObject>("Prefab"));
				MediaItem tempItem = tempObj.GetComponent<MediaItem>();
				if (tempItem == null)
				{
					tempObj.AddComponent<MediaItem>();
					tempItem = tempObj.GetComponent<MediaItem>();
					tempItem.InitItem(tempInfo[key]);
					if(!MediaInfoManager.Instance.DicAllItem.ContainsKey(key))
						MediaInfoManager.Instance.DicAllItem.Add (key, tempItem);
				}
			}
        }

        yield return new WaitForSeconds(0.1f);
    }

	/// <summary>
	/// 设置玩家的位置
	/// </summary>
	public void SetPlayerPosition(Vector3 pos,Vector3 rotate){
		objPlayer.transform.localPosition = pos;
		objPlayer.transform.localRotation = Quaternion.Euler (rotate);
	}

	/// <summary>
	/// 展示全景摄像机
	/// </summary>
	public void ShowCamera(){
		objRotateCamera.SetActive (true);
		objJoyCanvas.SetActive (false);
	}

	/// <summary>
	/// 隐藏全景摄像机
	/// </summary>
	public void HideCamera(){
		objRotateCamera.SetActive (false);
		objJoyCanvas.SetActive (true);
	}

	/// <summary>
	/// 旋转摄像机
	/// </summary>
	public void ShowCircleCamera(){
		objRotateCamera.GetComponent<CameraContral> ().DoMoveSircle ();
	}
}
