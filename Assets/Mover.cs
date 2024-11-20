using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of movement in units per second")]
    float speed = 1f;

    [SerializeField]
    [Tooltip("Direction of movement as a normalized vector")]
    Vector3 direction = Vector3.right;

    Transform objectTransform;

    void Start()
    {
        // Cache the Transform component
        objectTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Perform linear movement
        objectTransform.position += direction * speed * Time.deltaTime;
    }
}

