using TMPro;
using UnityEngine;

public class SaveSetting : MonoBehaviour
{
    [SerializeField] private TMP_Text _nameField;
    [SerializeField] private TMP_Text _alertText;
    [SerializeField] private int _minLength = 0;

    private GameObject _player;

    private GameObject _userName;
    private GameObject _settingCanvas;

    private string _saveText = "설정이 저장되었습니다.";
    private string _alertMinText = "글자 이상 입력해주세요.";
    private void Awake()
    {
        _player = GameObject.Find("Player");
        _userName = GameObject.Find("UserName");
        _settingCanvas = GameObject.Find("PlayerSettingCanvas");
    }


    public void SaveAction()
    {
        if (_nameField.text.Length > _minLength)
        {
            PlayerPrefs.SetString("PlayerName", _nameField.text);
            _alertText.text = _saveText;
             _userName.GetComponent<PlayerNameSetting>().CallNameRefresh();
            _player.GetComponent<TopDownAimRotation>().CallGetSpriteRenderer();
            TextHandler(Color.white);
            Invoke("CallCloseCanvasEvent", 2f);
        }
        else
        {
            _alertText.text = $"{_minLength}{_alertMinText}";
            TextHandler(Color.red);
        }
    }
    private void TextHandler(Color color)
    {
        _alertText.color = color;
        _alertText.enabled = true;
        Invoke("TextHide", 2f);
    }
    private void TextHide()
    {
        _alertText.enabled = false;
    }
    private void CallCloseCanvasEvent()
    {
        _settingCanvas.GetComponent<CanvasController>().CallCloseCanvas();
    }
}
