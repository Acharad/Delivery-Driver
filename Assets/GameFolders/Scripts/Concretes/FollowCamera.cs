using UnityEngine;

namespace GameFolders.Scripts.Concretes
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private GameObject thingToFollow;

        private void LateUpdate()
        {
            transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
        }
    }
}
