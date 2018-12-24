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

    private Dictionary<string, MediaItemInfo> dicMediaInfo;

    public Dictionary<string,MediaItemInfo> DicMediaInfo
    {
        get
        {
            if (dicMediaInfo == null)
            {
                dicMediaInfo = new Dictionary<string, MediaItemInfo>();
                SetDefaultMediaInfo();
            }

            return dicMediaInfo;
        }
    }

    private void SetDefaultMediaInfo()
    {
        MediaItemInfo tempInfo;
        string tempStr;

        #region 吊旗信息
        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-01",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-02",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-03",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-3-04",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-05",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-06",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-07",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 1,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-3-08",
            sMediaSize = "(单位：M) 10 x 5",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "吊旗",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }
        #endregion

        #region 包柱信息
        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-01",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-02",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-03",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层西广场",
            sMediaNumber = "CCM-CDD-H-1c-04",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-06",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-07",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 2,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车层东广场",
            sMediaNumber = "CCM-CDD-H-1c-08",
            sMediaSize = "(单位：M) 9.42 x 9",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "包柱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }
        #endregion

        #region 玻璃罩灯箱信息

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-01",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-02",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-03",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-04",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-05",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-06",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-07",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-08",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-09",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-10",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-11",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-12",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-13",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-14",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-15",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-16",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-17",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-18",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-19",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-20",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-21",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }

        tempInfo = new MediaItemInfo
        {
            iMediaType = 3,
            sMediaAssetNumber = "待定",
            sMediaLocation = "候车厅内",
            sMediaNumber = "CCM-CDD-H-1g-22",
            sMediaSize = "(单位：M) 3.2 x 0.93",
            v3MediaPosition = Vector3.zero,
            sMediaTypeName = "玻璃罩灯箱",
            v3MediaRotation = Vector3.zero
        };
        tempStr = tempInfo.sMediaTypeName + "," + tempInfo.sMediaAssetNumber;
        if (!dicMediaInfo.ContainsKey(tempStr))
        {
            dicMediaInfo.Add(tempStr, tempInfo);
        }
        #endregion

    }
}
