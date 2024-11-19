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
        float scale = Mathf.PingPong(Time.time * sizeSpeed, maxSize) + minSize;
        Debug.Log($"Scale value: {scale}"); // Debugging output
        transform.localScale = new Vector3(scale, scale, scale);
    }

}
