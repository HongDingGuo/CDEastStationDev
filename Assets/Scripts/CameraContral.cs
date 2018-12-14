using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContral : MonoBehaviour
{

    public GameObject obj_target;


    Vector3[] waypoints = new[]

    {
        new Vector3(18f,20f,335f),
        new Vector3(-170f,20f,255f),
        new Vector3(-310f,20f,0f),
        new Vector3(-213f,20f,-254f),
        new Vector3(20f,20f,-320f),
        new Vector3(286f,20f,-239f),
        new Vector3(336f,20f,0f),
        new Vector3(275f,20f,220f),
        new Vector3(18f,20f,335f),
    };

    public void DoMoveSircle()
    {
        transform.DOPath(waypoints, 30.0f, PathType.CatmullRom, PathMode.Full3D).SetOptions(false).SetLookAt(obj_target.transform).OnComplete(SetRotation);
    }

    private void SetRotation()
    {
        transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
    }

}
