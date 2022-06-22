using System;
using UnityEngine;

namespace GameFolders.Scripts.Concretes
{
    public class Collision : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            Debug.Log("collision enter " + col.gameObject.name); 
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            Debug.Log("trigger enter " + col.gameObject.name);
        }
    }
}
