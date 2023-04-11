using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private int _direction;
    public float _moveSpeed;

    private void Awake()
    {
        _direction = transform.position.x < 0 ? 1 : -1;
    }


    private void Update()
    {
        float speed = TimeController.instance._gameSpeed / _moveSpeed;
        transform.position += Vector3.right * _direction * speed * Time.deltaTime;
    }
}
