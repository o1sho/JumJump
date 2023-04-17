using UnityEngine;
using UnityEngine.Events;

public class TriggerCheck : MonoBehaviour
{
    [SerializeField] public UnityEvent Event;
    [SerializeField] public string triggerTag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == triggerTag)
        {
            Event.Invoke();
            Debug.Log("puk");
        }
    }
}
