using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of oscillation in cycles per second")]
    float speed = 1f;

    [SerializeField]
    [Tooltip("Amplitude of oscillation in units")]
    float amplitude = 3f;

    Vector3 initialPosition;
    Transform objectTransform;

    void Start()
    {
        // Cache the Transform component and initial position
        objectTransform = GetComponent<Transform>();
        initialPosition = objectTransform.position;
    }

    void Update()
    {
        // Perform oscillating movement
        float offset = Mathf.Sin(Time.time * speed) * amplitude;
        objectTransform.position = initialPosition + new Vector3(offset, 0, 0);
    }
}
