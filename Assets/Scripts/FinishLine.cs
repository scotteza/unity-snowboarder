using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterFinish = 2;
    [SerializeField] private ParticleSystem finishLineParticleSystem;

    private AudioSource _audioSource;

    private const string PlayerTag = "Player";

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(PlayerTag))
        {
            return;
        }

        finishLineParticleSystem.Play();
        _audioSource.Play();
        Invoke(nameof(ReloadScene), secondsToReloadSceneAfterFinish);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
