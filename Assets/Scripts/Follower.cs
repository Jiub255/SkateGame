using UnityEngine;

// Use cinemachine soon for camera, this just for setup
// Possibly use for player/board objects to follow rolling physics ball to simulate rolling downhill.
    // Could change offset (and angle) and sprite based on ground angle.
public class Follower : MonoBehaviour
{
    [SerializeField]
    private Transform followTarget;

    [SerializeField]
    private Vector3 offset;

    private void Update()
    {
        transform.position = followTarget.position + offset;
    }
}