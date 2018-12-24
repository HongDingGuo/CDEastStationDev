using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class GameManager : MonoBehaviour {

	private void Awake()
	{
		UIMgr.OpenPanel<UIStartPanel>(prefabName: "UIStartPanel");
	}
}
