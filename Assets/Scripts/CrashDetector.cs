using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("Ouch, hit my hand!");

            Invoke("ReloadScene", _loadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
