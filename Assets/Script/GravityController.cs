using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] float acceleration = 9.8f;

    Vector3 gravityOffset = Vector3.zero;
    bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
            Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            Debug.Log("gyro aktif");
            Physics.gravity = GetGravityFromSensor() + gravityOffset;
        }
        else
        {
            Debug.Log("gyro tidak aktif");
            Physics.gravity = Vector3.zero;
        }
    }

    public void CalibrateGravity()
    {
        gravityOffset = Vector3.down * acceleration - GetGravityFromSensor();
    }

    public Vector3 GetGravityFromSensor()
    {
        Vector3 gravity;
        if (Input.gyro.gravity != Vector3.zero)
            gravity = Input.gyro.gravity * acceleration;
        else
            gravity = Input.acceleration * acceleration;

        gravity.z = Mathf.Clamp(gravity.z, float.MinValue, -1);
        return new Vector3(gravity.x, gravity.z, gravity.y);
    }

    public void SetActive(bool value)
    {
        isActive = value;
        Debug.Log("akitffffffff " + isActive);
        if(value)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
