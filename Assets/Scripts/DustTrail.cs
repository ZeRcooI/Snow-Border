using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem _dustParticles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustParticles.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustParticles.Stop();
        }
    }
}