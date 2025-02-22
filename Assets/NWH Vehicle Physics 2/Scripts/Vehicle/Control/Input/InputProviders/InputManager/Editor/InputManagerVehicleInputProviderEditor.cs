﻿using NWH.NUI;
using UnityEditor;

namespace NWH.VehiclePhysics2.Input
{
    [CustomEditor(typeof(InputManagerVehicleInputProvider))]
    public class InputManagerVehicleInputProviderEditor : NVP_NUIEditor
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