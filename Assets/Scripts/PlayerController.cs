using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _torqueAmount = 0.7f;
    [SerializeField] private float _boostSpeed = 30;
    [SerializeField] private float _baseSpeed = 10;

    private Rigidbody2D _rigidbody2D;
    private SurfaceEffector2D _surfaceEffector2D;

    private bool _canMove = true;

    public void DisableControls()
    {
        _canMove = false;
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    private void Update()
    {
        if (_canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    private void RespondToBoost()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _surfaceEffector2D.speed = _boostSpeed;
        }
        else
        {
            _surfaceEffector2D.speed = _baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.AddTorque(-_torqueAmount);
        }
    }
}