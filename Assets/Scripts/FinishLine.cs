using UnityEngine;
using UnityEngine.SceneManagement;

// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

public class FinishLine : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != PlayerTag)
        {
            return;
        }

        SceneManager.LoadScene(0);
        Debug.Log($"Finished");
    }
}
