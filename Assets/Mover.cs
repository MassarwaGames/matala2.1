using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Speed of the oscillation (units per second)")]
    [SerializeField] private float speed = 1f;  // Speed of oscillation
    [Tooltip("Range of the oscillation (units)")]
    [SerializeField] private float range = 3f;  // Range of oscillation

    private Vector3 startPosition;  // Initial position of the object

    void Start()
    {
        // Save the starting position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using Mathf.Sin for smooth oscillation
        float offset = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPosition + new Vector3(offset, 0, 0); // Oscillate along the X-axis
    }
}

