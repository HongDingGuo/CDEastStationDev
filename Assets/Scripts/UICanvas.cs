using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvas : MonoBehaviour {
    #region Public

    public StartPanel startPanel;
    public MediaInfoPanel mediaInfoPalen;
    public GameMainPanel gameMainPanel;
    public GameObject obj_player;
    public GameObject obj_ShowCamera;
    public GameObject obj_joystick;
    #endregion

    private void Start()
    {
        obj_ShowCamera.SetActive(true);
        obj_player.SetActive(false);
        gameMainPanel.gameObject.SetActive(false);
        ShowJoyStickCanvas(false);
    }

    public void ShowJoyStickCanvas(bool b)
    {
        obj_joystick.SetActive(b);
    }
    
    public void ShowStartPanel()
    {
        obj_player.SetActive(false);
        obj_ShowCamera.SetActive(true);
        startPanel.gameObject.SetActive(true);
        gameMainPanel.gameObject.SetActive(false);
    }
}
