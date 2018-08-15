using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeControl : MonoBehaviour
{

    private bool gyroEnabled;
    private Gyroscope gyro;
    public GameObject Player;
    private Quaternion rot;

    // Use this for initialization
    void Start()
    {
        //Input.gyro.enabled = true;
        
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            Player.transform.rotation = Quaternion.Euler(90f, 90f, 0);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
        //transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, -Input.gyro.rotationRateUnbiased.z);
    }
}
