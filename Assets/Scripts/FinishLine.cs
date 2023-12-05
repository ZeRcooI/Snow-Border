using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 1;
    [SerializeField] ParticleSystem _finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _finishEffect.Play();
            Invoke(nameof(ReloadScene), _loadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
