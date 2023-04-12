using UnityEngine;
using UnityEngine.Events;

public class PlayerCheck : MonoBehaviour
{
    public UnityEvent Event;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreController.ScoreUp();
            Event.Invoke();
            
        }
    }
}
