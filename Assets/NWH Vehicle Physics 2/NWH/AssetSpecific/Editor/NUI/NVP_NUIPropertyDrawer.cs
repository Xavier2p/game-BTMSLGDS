﻿using UnityEditor;
using UnityEngine;

namespace NWH.NUI
{
    public class NVP_NUIPropertyDrawer : NUIPropertyDrawer
    {
        public override bool OnNUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!base.OnNUI(position, property, label))
            {
                return false;
            }
            
            drawer.documentationBaseURL = "http://nwhvehiclephysics.com/doku.php/";
            return true;
        }
    }
}