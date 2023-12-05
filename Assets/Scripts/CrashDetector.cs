using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 0.5f;
    [SerializeField] ParticleSystem _crashEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            _crashEffect.Play();
            Invoke(nameof(ReloadScene), _loadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
