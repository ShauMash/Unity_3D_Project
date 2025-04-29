using UnityEngine;

public class RotateRigid : MonoBehaviour
{
    public float torqueAmount = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddTorque(Vector3.up * torqueAmount, ForceMode.Force);
    }
}

