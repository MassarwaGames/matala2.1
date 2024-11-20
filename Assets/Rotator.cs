using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Rotation speed in degrees per second")]
    float rotationSpeed = 90f;

    Transform objectTransform;

    void Start()
    {
        // Cache the Transform component
        objectTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Perform continuous rotation
        objectTransform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
