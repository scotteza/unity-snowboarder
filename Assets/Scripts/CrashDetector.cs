using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterCrash = 2;
    [SerializeField] private ParticleSystem crashParticleSystem;
    [SerializeField] private AudioClip crashSoundEffect;

    private AudioSource _audioSource;
    private GameState _gameState;

    private const string GroundTag = "Ground";

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _gameState = FindObjectOfType<GameState>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(GroundTag))
        {
            return;
        }
        
        if (!_gameState.IsPlayerAlive())
        {
            return;
        }

        crashParticleSystem.Play();
        _audioSource.PlayOneShot(crashSoundEffect);
        _gameState.KillPlayer();
        Invoke(nameof(ReloadScene), secondsToReloadSceneAfterCrash);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
