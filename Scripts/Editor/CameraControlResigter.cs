using UnityEditor;
using UnityEngine;

namespace KleioSim.UI
{
    public static class CameraControlResigter
    {
        [MenuItem("GameObject/UI/KleioSim/CameraControl")]
        public static void AddDialogPanel(MenuCommand menuCommand)
        {
            var instance = Object.Instantiate(Resources.Load("CameraControl")) as GameObject;
            instance.name = "CameraControl";

            var parent = menuCommand.context as GameObject;
            if (parent != null)
            {
                instance.transform.parent = parent.transform;
            }
        }
    }
}

