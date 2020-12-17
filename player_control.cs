using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public VariableJoystick joy;
    float vinput;
    float hinput;
    [SerializeField] float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vinput = joy.Vertical;
        hinput = joy.Horizontal;
        Vector3 forwarded = transform.forward * speed;
        Vector3 hori = transform.right * speed;

        moveing(hinput, vinput, forwarded, hori);
    }
    void moveing(float x, float y, Vector3 forw, Vector3 hor)
    {
        rb.velocity = y * forw + x * hor;
    }
}
