using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeder : MonoBehaviour
{
    [SerializeField] float force;

    bool isSpeeding;

    private void OnCollisionEnter(Collision other)
    {
        Speed(other.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        Speed(other);
    }

    private void Speed(Collider other)
    {
        if (isSpeeding == false &&
            other.transform.CompareTag("Ball") &&
            other.transform.TryGetComponent<Rigidbody>(out var rb))
        {
            rb.AddForce(force * this.transform.forward, ForceMode.Impulse);
            isSpeeding = true;
            Invoke("Reset", 0.3f);
        }
    }

    private void Reset()
    {
        isSpeeding = false;
    }
}
