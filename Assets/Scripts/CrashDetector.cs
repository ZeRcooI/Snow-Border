using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 0.5f;
    [SerializeField] ParticleSystem _crashEffect;
    [SerializeField] private AudioClip _crashSound;
    private AudioSource _crashSoundSource;
    private bool _hasCrashed = false;

    private void Start()
    {
        _crashSoundSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground") && !_hasCrashed)
        {
            _hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            _crashEffect.Play();

            _crashSoundSource.PlayOneShot(_crashSound);
            Invoke(nameof(ReloadScene), _loadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}