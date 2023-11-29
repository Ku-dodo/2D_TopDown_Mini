using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeTextUI : MonoBehaviour
{
    public TMP_Text _text;

    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        _text.text = DateTime.Now.ToString("HH:mm");
        StartCoroutine(LiveTimeSet());
    }
    IEnumerator LiveTimeSet()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(10);
            _text.text = DateTime.Now.ToString("HH:mm");
        }
    }
}