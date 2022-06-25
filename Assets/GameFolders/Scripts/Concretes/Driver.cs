using System;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace GameFolders.Scripts.Concretes
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] float rotationSpeed = 125f;
        [SerializeField] float moveSpeed = 20f;
        private float slowSpeed;
        private float boostSpeed;

        // private Rigidbody2D _rb;

        private float _rotationAmount;
        private float _moveAmount;

        private void Awake()
        {
            slowSpeed = moveSpeed - 5f;
            boostSpeed = moveSpeed + 5f;
        }

        private void Start()
        {
            // gameObject.name = "McQueen";
            // _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
            _moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

            //_movement = new Vector3(0, moveAmount, rotationAmount);
            
            transform.Rotate(0, 0,-_rotationAmount);
            transform.Translate(0, _moveAmount, 0);
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Boost"))
            {
                moveSpeed = boostSpeed;
                Destroy(col.gameObject, 0.2f);
            }
        }
        
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.CompareTag("Obstacle"))
            {
                moveSpeed = slowSpeed;
            }
        }
    }
}
