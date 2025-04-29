using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 rotationSpeed = new Vector3(20, 0, 0); // Rotation speed on X, Y, Z

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
