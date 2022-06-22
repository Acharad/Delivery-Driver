using System;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace GameFolders.Scripts.Concretes
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] float rotationSpeed = 1f;
        [SerializeField] float moveSpeed = 0.01f;

        // private Rigidbody2D _rb;

        private float _rotationAmount;
        private float _moveAmount;
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

        


    }
}
