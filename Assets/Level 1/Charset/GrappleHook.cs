using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleHook : MonoBehaviour
{
    public float grappleSpeed = 10f; // Speed at which the player moves towards the grapple point
    public float grappleRange = 10f; // Maximum distance the grapple can reach
    public float grappleRadius = 0.5f; // Radius of the grapple check
    public LayerMask grappleMask; // Layer mask for objects that can be grappled

    private bool isGrappling = false; // Flag for whether the player is currently grappling
    private Vector2 grapplePoint; // Point where the grapple has hit
    private Vector2 grappleDirection; // Direction from the player to the grapple point

    private Rigidbody2D rb; // Rigidbody component of the player

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a circle in the direction of the mouse pointer to check for grapple points
            RaycastHit2D hit = Physics2D.CircleCast(transform.position, grappleRadius, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position, grappleRange, grappleMask);

            if (hit.collider != null)
            {
                // Grapple to the point if it is within range and can be grappled
                grapplePoint = hit.point;
                grappleDirection = (grapplePoint - (Vector2)transform.position).normalized;
                isGrappling = true;
            }
        }

        if (isGrappling)
        {
            // Move the player towards the grapple point at a constant speed
            rb.velocity = grappleDirection * grappleSpeed;

            // Stop grappling if the player reaches the grapple point or the grapple is obstructed
            if (Vector2.Distance(transform.position, grapplePoint) < 1f || Physics2D.Linecast(transform.position, grapplePoint, grappleMask))
            {
                isGrappling = false;
                rb.velocity = Vector2.zero;
            }
        }
    }
}

