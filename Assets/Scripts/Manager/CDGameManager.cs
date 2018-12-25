using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class CDGameManager : MonoBehaviour {


    public Transform tfDiaoQi;
    public Transform tfBaoZhu;
    public Transform tfBoLiZhaoDX;

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
                    tempObj.GetComponent<MediaItem>().InitItem(tempInfo[key]);
                }
            }

        }
        if (MediaInfoManager.Instance.DicBaoZhuInfo != null && MediaInfoManager.Instance.DicBaoZhuInfo.Count > 0)
        {

        }
        if (MediaInfoManager.Instance.DicBoLiZhaoDXInfo != null && MediaInfoManager.Instance.DicBoLiZhaoDXInfo.Count > 0)
        {

        }

        yield return new WaitForSeconds(0.1f);
    }
}
