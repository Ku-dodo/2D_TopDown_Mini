using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobContain : MonoBehaviour
{
    //�ڽ� ��ü�� ����Ʈ�� ����
    List<GameObject> _childList = new List<GameObject>();

    public event Action AnimStateReset;
    //�ִϸ��̼� Bool�� ������
    public string _controllBtnAnimBool = "isSelected";
    private void Awake()
    {
        //�ڽ� ��ü�� ����Ʈ�� ����
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

    //�ڽ� ��ü
    private void ChildAnimBoolisFalse()
    {
        foreach (GameObject child in _childList)
        {
            child.GetComponent<Animator>().SetBool(_controllBtnAnimBool, false);
        }
    }

}
