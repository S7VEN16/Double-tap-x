using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // The target object (usually the player) the camera will follow
    public Transform target;

    // How quickly the camera catches up to the target (0 to 1)
    [Range(0.01f, 1.0f)]
    public float smoothSpeed = 0.125f;

    // The desired offset from the Ball's position
    // (e.g., Vector3(0, 5, -10) for a standard 3rd person view)
    public Vector3 offset = new Vector3(0f, 5f, -10f);

    // Use FixedUpdate for camera movement to ensure smooth physics-based motion
    private void FixedUpdate()
    {
        if (target == null)
        {
            Debug.LogError("Camera Follow Error: Target transform is not assigned!");
            return;
        }

        // 1. Calculate the final position the camera *should* be at.
        Vector3 desiredPosition = target.position + offset;

        // 2. Smoothly move the camera towards that desired position.
        // Vector3.Lerp interpolates between the current position and the desired position.
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 3. Apply the new position to the camera's Transform.
        transform.position = smoothedPosition;

        // Optional: Make the camera always look directly at the target.
        // If you want a fixed-rotation camera, you can comment this out.
        transform.LookAt(target);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    }

}
