using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGround;

    private void Start()
    {
        isGround= false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGround=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGround = false;
        }
    }
}
