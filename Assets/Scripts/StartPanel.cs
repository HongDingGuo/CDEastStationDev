using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{

    #region Public

    public Button btn_Comfirm;
    public Button btn_North;
    public Button btn_South;
    public Button btn_West;
    public Button btn_East;
    public Button btn_Quit;
    
    public Transform tf_ShowCamera;
    public GameObject joystick;
    public GameObject obj_player;
    public GameMainPanel mainPanel;
    public CameraContral cc_showCamera;
    #endregion

    #region Private
    /// <summary>
    /// 状态数字，1 = 西；2 = 南；3 = 东；4 = 北
    /// </summary>
    private int i_statenNum = 1;

    #endregion
    
    public void ClickComfirm()
    {
        cc_showCamera.DoMoveSircle();
    }

    public void ClosePanel()
    {
        mainPanel.gameObject.SetActive(true);
        joystick.SetActive(true);
        tf_ShowCamera.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

    /// <summary>
    /// 北
    /// </summary>
    public void ClickNorth()
    {
        obj_player.transform.position = new Vector3(125,11,10);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0,270,0));
        obj_player.SetActive(true);
        ClosePanel();
     }

    /// <summary>
    /// 南
    /// </summary>
    public void ClickSouth()
    {
        obj_player.transform.position = new Vector3(-85, 11, 0);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
        obj_player.SetActive(true);
        ClosePanel();
    }

    /// <summary>
    /// 西
    /// </summary>
    public void ClickWest()
    {
        
        obj_player.transform.position = new Vector3(10, 11, -225);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        obj_player.SetActive(true);
        ClosePanel();
    }

    /// <summary>
    /// 东
    /// </summary>
    public void ClickEast()
    {
        obj_player.transform.position = new Vector3(0, 1, 250);
        obj_player.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
        obj_player.SetActive(true);
        ClosePanel();
    }

    /// <summary>
    /// 点击退出按钮
    /// </summary>
    public void ClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
