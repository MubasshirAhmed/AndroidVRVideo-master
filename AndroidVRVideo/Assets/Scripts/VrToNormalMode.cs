using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class VrToNormalMode : MonoBehaviour
{

    public void OnVREnableButtonDown()
    {
        ToggleVR();
    }

   private void ToggleVR()
    {
        if(XRSettings.loadedDeviceName == "cardboard")
        {
            StartCoroutine(LoadDevice("None"));
        }
        else
        {
            StartCoroutine(LoadDevice("cardboard"));
        }
    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = true;
    }
}
