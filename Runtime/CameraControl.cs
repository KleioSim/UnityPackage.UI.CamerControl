using UnityEngine;
using UnityEngine.Events;

namespace KleioSim.UI.CameraControl
{
    public class CameraControl : MonoBehaviour
    {
        public Camera TargetCamera;

        public float maxOrthographicSize;
        public float minOrthographicSize;

        public UnityEvent<Vector3> OnCameraMove;
        public UnityEvent<float> OnCameraUpdown;

        void Update()
        {
            if (ControlItem.isOn)
            {
                var pos = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
                var move = (pos - new Vector2(0.5f, 0.5f)) * 0.1f;

                TargetCamera.transform.position += (Vector3)move;

                OnCameraMove?.Invoke(move);
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
            var changed = 0.25f * (flag ? 1 : -1);

            var orthographicSize = Mathf.Min(maxOrthographicSize, Mathf.Max(minOrthographicSize, TargetCamera.orthographicSize + changed));

            TargetCamera.orthographicSize = orthographicSize;

            OnCameraUpdown?.Invoke(changed);
        }
    }

}
