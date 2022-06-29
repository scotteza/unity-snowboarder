using System;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustTrailParticleSystem;
    
    private GameState _gameState;

    private const string GroundTag = "Ground";

    private void Start()
    {
        _gameState = FindObjectOfType<GameState>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_gameState.IsPlayerAlive())
        {
            return;
        }
        
        if (collision.gameObject.CompareTag(GroundTag))
        {
            dustTrailParticleSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            dustTrailParticleSystem.Stop();
        }
    }
}
