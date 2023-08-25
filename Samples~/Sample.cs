using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KleioSim.UI.CameraControl.Samples
{
    public class Sample : MonoBehaviour
    {

        public void OnCameraMoved(Vector3 offset)
        {
            Debug.Log($"OnCameraMoved {offset}");
        }

        public void OnCameraUpdown(float offset)
        {
            Debug.Log($"OnCameraUpdown {offset}");
        }
    }
}