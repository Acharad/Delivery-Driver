using System;
using UnityEngine;

namespace GameFolders.Scripts.Concretes
{
    public class Delivery : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.CompareTag("Customer"))
                Debug.Log("Package Delivered"); 
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Package"))
            {
                Debug.Log("Package picked up");
            }
        }
    }
}
