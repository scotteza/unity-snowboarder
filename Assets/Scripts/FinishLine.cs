using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterFinish = 0.5f;
    [SerializeField] private ParticleSystem finishEffect;

    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(PlayerTag))
        {
            return;
        }

        finishEffect.Play();
        Invoke(nameof(ReloadScene), secondsToReloadSceneAfterFinish);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}