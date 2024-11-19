using UnityEngine;

public class Hider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Tooltip("Key to toggle visibility")]
    [SerializeField] private KeyCode toggleKey = KeyCode.H;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            // Properly toggle the active state
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
