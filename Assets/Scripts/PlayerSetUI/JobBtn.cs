using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class JobBtn : MonoBehaviour
{
    private Animator _animator;
    private GameObject _parent;
    private GameObject _player;
    public string _controllBtnAnimBool = "isSelected";
    public void Awake()
    {
        _player = GameObject.Find("Player");
        _parent = transform.parent.gameObject;
        _animator = GetComponent<Animator>();
    }

    public void SelectJob()
    {
        PlayerPrefs.SetString("JobName", gameObject.name);
        Debug.Log(PlayerPrefs.GetString("JobName") + "이 저장되었어요.");
        _parent.GetComponent<JobContain>().CallAnimStateReset();
        _player.GetComponent<AddChildPrefab>().CallPrefabAdd();
        _animator.SetBool(_controllBtnAnimBool, true);
    }
    
}
