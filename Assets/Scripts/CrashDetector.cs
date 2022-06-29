using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterCrash = 0.5f;
    [SerializeField] private ParticleSystem crashEffect;

    private const string GroundTag = "Ground";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(GroundTag))
        {
            return;
        }

        crashEffect.Play();
        Invoke(nameof(ReloadScene), secondsToReloadSceneAfterCrash);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
