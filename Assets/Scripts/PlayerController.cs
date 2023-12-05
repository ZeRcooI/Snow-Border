using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _torqueAmount = 0.7f;
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
         _rigidbody2D  = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.AddTorque(-_torqueAmount);
        }
    }
}
