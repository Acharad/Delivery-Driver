using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameFolders.Scripts.Concretes
{
    public class Delivery : MonoBehaviour
    {
        [FormerlySerializedAs("_hasPackage")] [SerializeField] private bool hasPackage;

        private SpriteRenderer _spriteRenderer;
        private Color _carColor;

        private void Awake()
        {
            _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            _carColor = _spriteRenderer.color;
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.CompareTag("Customer") && hasPackage)
            {
                Debug.Log("Package Delivered");
                hasPackage = false;
                _spriteRenderer.color = _carColor;
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Package") && !hasPackage)
            {
                var packageSpriteRenderer = col.gameObject.GetComponent<SpriteRenderer>();
                Debug.Log("Package picked up");
                
                hasPackage = true;
                Destroy(col.gameObject, 0.3f);
                _spriteRenderer.color = packageSpriteRenderer.color;
            }
        }
    }
}
