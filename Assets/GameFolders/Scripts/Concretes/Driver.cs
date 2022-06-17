using System;
using UnityEngine;

namespace GameFolders.Scripts.Concretes
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] float rotationSpeed = 1f;
        [SerializeField] float moveSpeed = 0.01f;
        private void Start()
        {
            gameObject.name = "McQueen";
        }

        private void Update()
        {
            var rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed;
            var moveAmount = Input.GetAxis("Vertical") * moveSpeed;
            transform.Rotate(0, 0,-rotationAmount);
            transform.Translate(0, moveAmount, 0);
        }
    }
}
