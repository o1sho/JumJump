using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent Landed;
    public UnityEvent Death;

    private Rigidbody2D _rb;

    public float jumpForse;

    private void Awake()
    {
        _rb= GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (GroundCheck.isGround)
        _rb.AddForce(Vector2.up * jumpForse, ForceMode2D.Impulse);

        if (!GroundCheck.isGround)
        _rb.AddForce(Vector2.down * jumpForse * 2, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) Jump();
    }

    /* public void Down()
    {
        if (!GroundCheck.isGround)
        _rb.AddForce(Vector2.down * jumpForse * 2, ForceMode2D.Impulse);
    } */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Landed.Invoke();
            Debug.Log("Landed");
        }

        if (collision.gameObject.tag == "Death")
        {
            Death.Invoke();
            Debug.Log("Death");
        }

    }

}
