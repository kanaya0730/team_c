using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Header("Playerのスピード")]
    protected float _speed = 10f;

    [SerializeField]
    [Header("ジャンプ力")]
    float _jumpPower = 10f;

    [SerializeField]
    [Header("PlayerのHp")]
    float _playerHp = 3;

    protected Rigidbody2D _rb;
    protected Vector2 _dir;
    SpriteRenderer _sp;
    bool _isGrounded = false;
    float _x;

    /// <summary>GetComponentする</summary>
    protected virtual void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        GameOver();
        OnMove();//横移動
        OnJump();//ジャンプ
        _rb.velocity = _dir;//移動
    }

    /// <summary>横移動</summary>
    void OnMove()
    {
        _x = Input.GetAxisRaw("Horizontal");
        _dir = new Vector2(_x * _speed, _rb.velocity.y);
        Inversion();//スプライトの向き
    }

    /// <summary>地面についていたらジャンプできる</summary>
    void OnJump()
    {
        if (_isGrounded && Input.GetButtonDown("Jump"))
        {
            _dir = Vector2.up * _jumpPower;
            Debug.Log("押された");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }

    /// <summary>移動方向でSpriteの向きを変える</summary>
    void Inversion()
    {
        if (_dir.x > 0)　
        {
            _sp.flipX = false;
        }
        else if (_dir.x < 0)
        {
            _sp.flipX = true;
        }
    }

    void Dead()
    {
        _rb.freezeRotation = false;
    }

    void GameOver()
    {
        if(_playerHp < 1)
        {
            Dead();
        }
    }
}
