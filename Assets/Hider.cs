using UnityEngine;

public class Hider : MonoBehaviour
{
    [Tooltip("Key to toggle visibility")]
    [SerializeField] private KeyCode toggleKey = KeyCode.H;

    void Update()
    {
        // Incorrectly use SetActive without toggling properly
        if (Input.GetKeyDown(toggleKey))
        {
            gameObject.SetActive(false); // Always hides, doesn't toggle
        }
    }
}
