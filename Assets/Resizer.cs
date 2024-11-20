using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the size change (beats per second)")]
    float sizeSpeed = 1f;

    [SerializeField]
    [Tooltip("Maximum size multiplier")]
    float maxSize = 1.5f;

    [SerializeField]
    [Tooltip("Minimum size multiplier")]
    float minSize = 0.5f;

    Transform objectTransform;

    void Start()
    {
        // Cache the Transform component
        objectTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Calculate and apply the new scale
        float scale = Mathf.PingPong(Time.time * sizeSpeed, maxSize - minSize) + minSize;
        objectTransform.localScale = new Vector3(scale, scale, scale);
    }
}
