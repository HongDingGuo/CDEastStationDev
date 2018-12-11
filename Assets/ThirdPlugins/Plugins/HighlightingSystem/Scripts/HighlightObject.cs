using HighlightingSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 将此脚本挂载到需要高亮的物体上
/// required package: Highlighting System
/// </summary>
public class HighlightObject : MonoBehaviour
{
    protected Highlighter h;

    public enum HighlightType
    {
        Once,//变化一次
        Constant,//持续
        Flash//闪烁
    }

    public Color highlightColor = Color.red;

    void Awake()
    {
        h = gameObject.AddComponent<Highlighter>();
        if (Camera.main.GetComponent<HighlightingRenderer>() == null)
        {
            Camera.main.gameObject.AddComponent<HighlightingRenderer>();
        }
    }

    /// <summary>
    /// API:修改物体是否开启高亮
    /// </summary>
    /// <param name="showHightlight">是否开启高亮</param>
    public void SwithHightlight(bool showHightlight)
    {
        SwithHightlight(showHightlight, HighlightType.Once);
    }

    /// <summary>
    /// API:修改物体是否开启高亮
    /// </summary>
    /// <param name="showHightlight">是否开启高亮</param>
    /// <param name="type">高亮类型</param>
    public void SwithHightlight(bool showHightlight, HighlightType type)
    {
        switch (type)
        {
            case HighlightType.Once:
                if (showHightlight)
                    h.ConstantOnImmediate(highlightColor);
                else
                    h.ConstantOffImmediate();
                break;

            case HighlightType.Constant:
                if (showHightlight)
                    h.ConstantOn(highlightColor);
                else
                    h.ConstantOff();
                break;

            case HighlightType.Flash:
                if (showHightlight)
                    h.FlashingOn(highlightColor, new Color(0, 0, 0, 0));
                else
                    h.TweenStop();
                break;
        }
    }

    #region 测试：QWE键控制高亮类型
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwithHightlight(true);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            SwithHightlight(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SwithHightlight(true, HighlightType.Constant);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            SwithHightlight(false, HighlightType.Constant);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwithHightlight(true, HighlightType.Flash);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            SwithHightlight(false, HighlightType.Flash);
        }
    }
    #endregion

}