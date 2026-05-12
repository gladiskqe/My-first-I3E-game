using UnityEngine;

public class rotatecoin : MonoBehaviour
{
    private float rotateSpeed = 0.1f;  // Declare rotateSpeed as a field with initial value

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed, 0, 0);
    }
}
