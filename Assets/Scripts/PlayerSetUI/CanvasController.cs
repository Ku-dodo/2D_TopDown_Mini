using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    private event Action OpenCanvas;
    private event Action CloseCanvas;
    private GameObject _canvas;

    private void Awake()
    {
        OpenCanvas += IsOpenCanvas;
        CloseCanvas += IsCloseCanvas;
    }
    // Start is called before the first frame update
    public void CallOpenCanvas()
    {
        Debug.Log("�̰� ��?");
        OpenCanvas?.Invoke();
    }

    public void CallCloseCanvas()
    {
        CloseCanvas?.Invoke();
    }
    private void IsOpenCanvas()
    {
        Debug.Log("�̰� ��");
        gameObject.SetActive(true);
    }
    private void IsCloseCanvas()
    {
        Debug.Log("�̰� ��");
        gameObject.SetActive(false);
    }
}
