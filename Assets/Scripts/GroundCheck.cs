using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGround;
    [SerializeField] private string _tagCollision;

    private void Start()
    {
        isGround= false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == _tagCollision)
        {
            isGround=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == _tagCollision)
        {
            isGround = false;
        }
    }
}
