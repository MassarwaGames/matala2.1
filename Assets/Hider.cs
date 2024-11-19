using UnityEngine;

public class Hider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Tooltip("Key to toggle visibility")]
    [SerializeField] KeyCode toggleKey = KeyCode.H;

    Renderer objectRenderer;
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
