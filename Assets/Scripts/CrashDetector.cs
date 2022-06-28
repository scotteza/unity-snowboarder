using UnityEngine;

// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

public class CrashDetector : MonoBehaviour
{
    private const string GroundTag = "Ground";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == GroundTag)
        {
            Debug.Log("Hit head");
        }
    }
}
