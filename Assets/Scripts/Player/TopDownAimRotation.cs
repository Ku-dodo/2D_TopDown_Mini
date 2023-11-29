using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _characterRenderer;
    [SerializeField] private Transform _pivot;
    private TopDownCharacterController _controller;

    private GameObject _settingCanvas;

    private event Action GetSpriteRenderer;
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _settingCanvas = GameObject.Find("PlayerSettingCanvas");
        GetSpriteRenderer += SpriteRendererMethod;
    }
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }
    public void OnAim(Vector2 newAimDirection)
    {
        if (_settingCanvas.activeSelf == false)
        {
            RotateCamera(newAimDirection);
        }
    }
    public void RotateCamera(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        _pivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    public void CallGetSpriteRenderer()
    {
        Debug.Log("CallGetSpriteRenderer");
        GetSpriteRenderer?.Invoke();
    }

    private void SpriteRendererMethod()
    {
        _characterRenderer = GetComponentInChildren<SpriteRenderer>();
    }
}
