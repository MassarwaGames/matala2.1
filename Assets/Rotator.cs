using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    [SerializeField] private Vector3 rotationSpeed = new Vector3(0, 90, 0);

    void Update()
    {
        // Rotate the object continuously
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
