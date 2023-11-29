using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActiveBtn : MonoBehaviour
{
    private GameObject _settingCanvas;
    private void Awake()
    {
        _settingCanvas = GameObject.Find("PlayerSettingCanvas");
    }
    public void ActiveCanvas()
    {
        _settingCanvas.GetComponent<CanvasController>().CallOpenCanvas();
    }
}
