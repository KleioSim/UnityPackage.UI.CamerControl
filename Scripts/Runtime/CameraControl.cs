using UnityEngine;

namespace KleioSim.UI
{
    public class CameraControl : MonoBehaviour
    {
        public Camera TargetCamera;

        void Update()
        {
            if (ControlItem.isOn)
            {
                var pos = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
                var move = (pos - new Vector2(0.5f, 0.5f)) * 0.1f;

                TargetCamera.transform.position += (Vector3)move;
            }

            var mouseScrollWheel = Input.GetAxis("Mouse ScrollWheel");
            if (mouseScrollWheel > 0)
            {
                OnScrollWheel(true);
            }
            if (mouseScrollWheel < 0)
            {
                OnScrollWheel(false);
            }
        }

        private void OnScrollWheel(bool flag)
        {
            var newSize = TargetCamera.orthographicSize + 0.25f * (flag ? 1 : -1);

            //newSize = Mathf.Min(newSize, maxOrthoSize);
            //newSize = Mathf.Max(newSize, minOrthoSize);

            TargetCamera.orthographicSize = newSize;
        }
    }

}
