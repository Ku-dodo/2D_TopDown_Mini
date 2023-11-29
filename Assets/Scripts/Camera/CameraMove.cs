using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    void LateUpdate()
    {
        Vector3 destination = new Vector3(_gameObject.transform.position.x, _gameObject.transform.position.y, -10);
        transform.position = Vector3.MoveTowards (transform.position, destination, 0.5f);
    }
}
