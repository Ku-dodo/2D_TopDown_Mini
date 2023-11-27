using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class AnimationController : MonoBehaviour
{
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    

    private void Awake()
    {
        _gameObject = GameObject.Find("Player");
        _rigidbody = _gameObject.GetComponent<Rigidbody2D>();

        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(_rigidbody.velocity == Vector2.zero)
        {
            _animator.SetBool("isMove", false);
        }
        else if(_rigidbody.velocity != Vector2.zero)
        {
            _animator.SetBool("isMove", true);
        }
        
        
    }
}
