using System;
using UnityEngine;

public class NpcInteractiveUI : MonoBehaviour
{
    private GameObject _keyGuild;

    private event Action _InteractUITrue;
    private event Action _InteractUIFalse;

    void Start()
    {
        _keyGuild = transform.Find("KeyGuideBox").gameObject;
        _InteractUITrue += InteractiveUIActive;
        _InteractUIFalse += InteractiveUIInactive;
    }

    public void CallInteractionUITrue()
    {
        _InteractUITrue?.Invoke();
    }
    public void CallInteractionUIFalse()
    {
        _InteractUIFalse?.Invoke();
    }

    private void InteractiveUIActive()
    {
        _keyGuild.SetActive(true);
    }
    private void InteractiveUIInactive()
    {
        _keyGuild?.SetActive(false);
    }
}
