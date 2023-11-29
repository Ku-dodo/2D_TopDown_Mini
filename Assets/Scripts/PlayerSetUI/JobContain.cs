using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobContain : MonoBehaviour
{
    //자식 객체를 리스트에 담음
    List<GameObject> _childList = new List<GameObject>();

    public event Action AnimStateReset;
    //애니메이션 Bool의 변수명
    public string _controllBtnAnimBool = "isSelected";
    private void Awake()
    {
        //자식 객체를 리스트에 넣음
        for (int i = 0; i < transform.childCount; i++)
        {
            _childList.Add(transform.GetChild(i).gameObject);
        }
    }
    private void Start()
    {
        AnimStateReset += ChildAnimBoolisFalse;
    }

    public void CallAnimStateReset()
    {
        AnimStateReset?.Invoke();
    }

    //자식 객체
    private void ChildAnimBoolisFalse()
    {
        foreach (GameObject child in _childList)
        {
            child.GetComponent<Animator>().SetBool(_controllBtnAnimBool, false);
        }
    }

}
