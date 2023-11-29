using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameSetting : MonoBehaviour
{
    private TextMesh _nameText;

    private event Action NameRefresh;
    private void Awake()
    {
        _nameText = gameObject.GetComponent<TextMesh>();
        NameRefresh += PlayerNameRefresh;
    }

    public void CallNameRefresh()
    {
        NameRefresh?.Invoke();
    }

    public void PlayerNameRefresh()
    {
        _nameText.text = PlayerPrefs.GetString("PlayerName");
    }
}
