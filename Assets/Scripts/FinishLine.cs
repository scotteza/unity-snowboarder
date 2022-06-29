using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float secondsToReloadSceneAfterFinish = 2;
    [SerializeField] private ParticleSystem finishLineParticleSystem;

    private AudioSource _audioSource;
    private GameState _gameState;

    private const string PlayerTag = "Player";

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _gameState = FindObjectOfType<GameState>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(PlayerTag))
        {
            return;
        }
        
        if (!_gameState.IsPlayerAlive())
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
