using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You finished!!!");

            if (collision.tag == "Player")
            {
                Invoke("ReloadScene", _loadDelay);
            }
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
