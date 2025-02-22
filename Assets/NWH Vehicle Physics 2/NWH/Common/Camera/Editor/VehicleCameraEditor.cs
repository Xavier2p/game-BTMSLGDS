﻿﻿using NWH.NUI;
using UnityEditor;

namespace NWH.Common.Cameras
{
    [CustomEditor(typeof(VehicleCamera))]
    [CanEditMultipleObjects]
    public class VehicleCameraEditor : NUIEditor
    {
        public override bool OnInspectorNUI()
        {
            if (!base.OnInspectorNUI())
            {
                return false;
            }

            drawer.EndEditor(this);
            return true;
        }

        public override bool UseDefaultMargins()
        {
            return false;
        }
    }
}