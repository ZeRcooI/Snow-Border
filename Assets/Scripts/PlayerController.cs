using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 0.5f;
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
         _rigidbody2D  = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.AddTorque(torqueAmount);
        }
    }
}
