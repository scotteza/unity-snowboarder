using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _secondsToReloadSceneAfterCrash = 0.5f;
    [SerializeField] private ParticleSystem _crashEffect;

    private const string GroundTag = "Ground";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != GroundTag)
        {
            return;
        }

        _crashEffect.Play();
        Invoke(nameof(ReloadScene), _secondsToReloadSceneAfterCrash);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
