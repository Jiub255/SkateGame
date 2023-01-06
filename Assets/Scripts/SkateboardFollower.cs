using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateboardFollower : MonoBehaviour
{
    [SerializeField]
    private Transform followTarget;

    [SerializeField]
    private float boardHalfLength = 0.5f;

    [Tooltip("Raycast will be twice this length"), SerializeField]
    private float raycastOriginHeight = 15f;

    [SerializeField]
    private LayerMask groundLayer;

    // Just sets rotation based on two vertical raycasts into the ground where the wheels are.
    // Calculate slope based off that and rotate board accordingly.
    // Set board position based on frontPoint and backPoint.
        // Make the board's origin point be the bottom center, where it hits the ground.
        // Wont be issues where the ground kinks this way.

    private void Update()
    {
        Vector2 frontPoint = RaycastAtX(followTarget.position.x + boardHalfLength);
        Vector2 backPoint = RaycastAtX(followTarget.position.x - boardHalfLength);

        // Set position based off midpoint of front and back points
        Vector2 midpoint = (frontPoint + backPoint) / 2;

        transform.position = midpoint;

        // Set rotation based off inverse tan of slope, only if both wheels above ground
        if (frontPoint != Vector2.zero && backPoint != Vector2.zero)
        {
            // Find slope
            float slope = (frontPoint.y - backPoint.y) / (frontPoint.x - backPoint.x);
            // Inverse tan is angle
            float angle = Mathf.Rad2Deg * Mathf.Atan(slope);

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    private Vector2 RaycastAtX(float xCoordinate)
    {
        float y = followTarget.position.y + raycastOriginHeight;

        Vector3 origin = new Vector3(xCoordinate, y, 0f);

        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, raycastOriginHeight * 2, groundLayer);
        if (hit.collider != null)
        {
            return hit.point;
        }

        //Debug.Log("Couldn't find ground with raycast");
        return Vector2.zero;
    }
}