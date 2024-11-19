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
        // Incorrectly use maxSize directly instead of calculating the range
        float scale = Mathf.PingPong(Time.time * sizeSpeed, maxSize) + minSize;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
