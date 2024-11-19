using UnityEngine;

public class Resizer : MonoBehaviour
{
    [Tooltip("Speed of the size change (beats per second)")]
    [SerializeField] private float sizeSpeed = 1f;
    [Tooltip("Maximum size multiplier")]
    [SerializeField] private float maxSize = 1.5f;
    [Tooltip("Minimum size multiplier")]
    [SerializeField] private float minSize = 0.5f;

    void Update()
    {
        // Correctly calculate the range for PingPong
        float scale = Mathf.PingPong(Time.time * sizeSpeed, maxSize - minSize) + minSize;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
