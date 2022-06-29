using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterCrash = 2;
    [SerializeField] private ParticleSystem crashParticleSystem;
    [SerializeField] private AudioClip crashSoundEffect;

    private AudioSource _audioSource;

    private const string GroundTag = "Ground";

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(GroundTag))
        {
            return;
        }

        crashParticleSystem.Play();
        _audioSource.PlayOneShot(crashSoundEffect);
        Invoke(nameof(ReloadScene), secondsToReloadSceneAfterCrash);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
