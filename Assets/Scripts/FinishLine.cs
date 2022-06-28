using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == PlayerTag)
        {
            Debug.Log($"Finished");
        }
    }
}
