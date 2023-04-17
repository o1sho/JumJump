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

    private void Start()
    {
        var player = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        if (_direction == 1)
        {
            player.flipX= true;
        } else if (_direction == -1) player.flipX= false;
    }

    private void Update()
    {
        float speed = TimeController.instance._gameSpeed / _moveSpeed;
        transform.position += Vector3.right * _direction * speed * Time.deltaTime;
    }


}
