using QFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaInfoManager : ISingleton
{

    public void OnSingletonInit()
    {
        Log.I("QUIPanelStack init");
    }

    private MediaInfoManager()
    {
    }

    private static MediaInfoManager mInstance;

    public static MediaInfoManager Instance
    {
        get
        {
            if (null == mInstance)
            {
                mInstance = SingletonProperty<MediaInfoManager>.Instance;
            }
            return mInstance;
        }
    }
    
    private Dictionary<string, MediaItemInfo> dicDiaoQiInfo;
    /// <summary>
    /// 吊旗信息
    /// </summary>
    public Dictionary<string, MediaItemInfo> DicDiaoQiInfo
    {
        get
        {
            if (dicDiaoQiInfo == null)
            {
                dicDiaoQiInfo = new Dictionary<string, MediaItemInfo>();
                GetDefaultDiaoQiInfo();
            }
            return dicDiaoQiInfo;
        }
    }

    private Dictionary<string, MediaItemInfo> dicBaoZhuInfo;
    /// <summary>
    /// 包柱信息
    /// </summary>
    public Dictionary<string, MediaItemInfo> DicBaoZhuInfo
    {
        get
        {
            if (dicBaoZhuInfo == null)
            {
                dicBaoZhuInfo = new Dictionary<string, MediaItemInfo>();
                GetDefaultBaoZhuInfo();
            }
            return dicBaoZhuInfo;
        }
    }

    private Dictionary<string, MediaItemInfo> dicBoLiZhaoDXInfo;
    /// <summary>
    /// 候车层玻璃罩灯箱信息
    /// </summary>
    public Dictionary<string, MediaItemInfo> DicBoLiZhaoDXInfo
    {
        get
        {
            if (dicBoLiZhaoDXInfo == null)
            {
                dicBoLiZhaoDXInfo = new Dictionary<string, MediaItemInfo>();
                GetDefaultBoLiZhaoDXInfo();
            }
            return dicBoLiZhaoDXInfo;
        }
    }

	/// <summary>
	/// 搜索功能的实现
	/// </summary>
	public void DoSearchItem(string searchkey){
		if (DicAllItem == null) {
			Debug.LogError (" no items info ...");
			return;
		}
		string tempStr = "";
		foreach (string keys in DicAllItem.Keys) {
			string[] strArray = keys.Split (',');
			if (strArray != null && strArray.Length > 0) {
				int arrayLength = strArray.Length;
				for (int i = 0; i < arrayLength; ++i) {
					if (searchkey.Equals (strArray [i])) {
						DicAllItem [keys].ShowHighLight ();
						CDGameManager.Instance.SetPlayerPosition (Vector3.zero,Vector3.zero);
						Debug.LogError (" ... search is : "+ keys);
						return;
					}
				}

			}

		}
	}

	/// <summary>
	/// 隐藏所有媒体点位的高亮显示
	/// </summary>
	public void HideAllItemHighLight(){
		if (DicAllItem != null) {
			foreach(string key in DicAllItem.Keys){
				DicAllItem [key].HideHightLight();
			}
		}
	}

    #region 临时媒体信息

    /// <summary>
    /// 获取测试用吊旗信息
    /// </summary>
    private void GetDefaultDiaoQiInfo()
    {
        MediaItemInfo tempInfo;
        string tempStr;
        #region 吊旗信息
        dicDiaoQiInfo = new Dictionary<string, MediaItemInfo>();
        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-01",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(143f, 38f, 109f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-02",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(143f, 38f, 63.5f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-03",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(143f, 38f, -63.5f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-04",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(143f, 38f, -109f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-05",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(92f, 38f, 109f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-06",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(92f, 38f, 63.5f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-07",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(92f, 38f, -63.5f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-08",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = new Vector3(92f, 38f, -109f),
            sMediaTypeName = "吊旗",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicDiaoQiInfo.ContainsKey(tempStr))
        {
            dicDiaoQiInfo.Add(tempStr, tempInfo);
        }
        #endregion
    }

    /// <summary>
    /// 获取测试用包柱信息
    /// </summary>
    private void GetDefaultBaoZhuInfo()
    {
        MediaItemInfo tempInfo;
        string tempStr;

        #region 包柱信息
        dicBaoZhuInfo = new Dictionary<string, MediaItemInfo>();
        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-01",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(155.25f, 32f, 107.25f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-02",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(155.25f, 32f, 64.25f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-03",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(155.25f, 32f, -64.7f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-04",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(155.25f, 32f, -108.4f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-05",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(82.25f, 32f, -108.4f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-06",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(82.25f, 32f, -64.7f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-07",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(82.25f, 32f, 64.25f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-08",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = new Vector3(82.25f, 32f, 107.25f),
            sMediaTypeName = "包柱",
            v3MediaRotation = new Vector3(270f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBaoZhuInfo.ContainsKey(tempStr))
        {
            dicBaoZhuInfo.Add(tempStr, tempInfo);
        }

        #endregion
    }

    /// <summary>
    /// 获取测试用玻璃罩灯箱信息
    /// </summary>
    public void GetDefaultBoLiZhaoDXInfo()
    {
        MediaItemInfo tempInfo;
        string tempStr;

        #region 玻璃罩灯箱信息
        dicBoLiZhaoDXInfo = new Dictionary<string, MediaItemInfo>();
        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-01",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f,21.75f,113.65f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f,0f,0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-02",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 92.25f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-03",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 70.5f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-04",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 49.4f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-05",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 27.9f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-06",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 6.25f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-07",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, 15.3f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-08",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, -36.5f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-09",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, -58.1f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-10",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, -79.65f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-11",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(133f, 21.75f, -101.35f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-12",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(104.7f, 21.75f, -113.3f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = new Vector3(90f, 0f, 0f)
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-13",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(104.5f, 21.75f, -91.7f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-14",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(104.25f, 21.75f, -70.15f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-15",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(103.8f, 21.75f, -48.64f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-16",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(103.7f, 21.75f, -27.05f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-17",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(103.4f, 21.75f, -5.5f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-18",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(103.2f, 21.75f, 15.7f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-19",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(102.9f, 21.75f, 37.4f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-20",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(102.7f, 21.75f, 58.7f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-21",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(102.4f, 21.75f, 80.2f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-22",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = new Vector3(102.15f, 21.75f, 101.7f),
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaNumber;
        if (!dicBoLiZhaoDXInfo.ContainsKey(tempStr))
        {
            dicBoLiZhaoDXInfo.Add(tempStr, tempInfo);
        }
        #endregion

    }

    #endregion

    #region 管理

    private Dictionary<string, MediaItem> dicAllItem;
    public Dictionary<string, MediaItem> DicAllItem
    {
        get
        {
            if(dicAllItem == null)
            {
                dicAllItem = new Dictionary<string, MediaItem>();
            }
            return dicAllItem;
        }
        set
        {
            dicAllItem = value;
        }
    }
    private Dictionary<string, MediaItem> dicDiaoQi;
    public Dictionary<string, MediaItem> DicDiaoQi
    {
        get
        {
            if(dicDiaoQi == null)
            {
                dicDiaoQi = new Dictionary<string, MediaItem>();
            }
            return dicDiaoQi;
        }
        set
        {
            dicDiaoQi = value;
        }
    }

    private Dictionary<string, MediaItem> dicBaoZhu;
    public Dictionary<string, MediaItem> DicBaoZhu
    {
        get
        {
            if (dicBaoZhu == null)
            {
                dicBaoZhu = new Dictionary<string, MediaItem>();
            }
            return dicBaoZhu;
        }
        set
        {
            dicBaoZhu = value;
        }
    }

    private Dictionary<string, MediaItem> dicBoLiZhaoDX;
    public Dictionary<string, MediaItem> DicBoLiZhaoDX
    {
        get
        {
            if(dicBoLiZhaoDX == null)
            {
                dicBoLiZhaoDX = new Dictionary<string, MediaItem>();
            }
            return dicBoLiZhaoDX;
        }
        set
        {
            dicBoLiZhaoDX = value;
        }
    }
    #endregion
}
