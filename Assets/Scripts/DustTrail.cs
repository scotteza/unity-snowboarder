using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem snowEffect;

    private const string GroundTag = "Ground";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            snowEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            snowEffect.Stop();
        }
    }
}