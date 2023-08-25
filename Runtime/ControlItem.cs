using UnityEngine;
using UnityEngine.EventSystems;

namespace KleioSim.UI.CameraControl
{
    public class ControlItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public static bool isOn;

        // Start is called before the first frame update
        void Start()
        {
            isOn = false;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            isOn = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            isOn = false;
        }
    }
}