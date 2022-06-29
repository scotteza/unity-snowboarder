using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _secondsToReloadSceneAfterFinish = 0.5f;
    [SerializeField] private ParticleSystem _finishEffect;

    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != PlayerTag)
        {
            return;
        }

        _finishEffect.Play();
        Invoke(nameof(ReloadScene), _secondsToReloadSceneAfterFinish);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
