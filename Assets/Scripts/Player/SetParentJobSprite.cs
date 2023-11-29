using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParentJobSprite : MonoBehaviour
{
    GameObject _parents;
    private void Awake()
    {
        _parents = GameObject.Find("Player");
        transform.SetParent(_parents.transform, false);
    }
}
