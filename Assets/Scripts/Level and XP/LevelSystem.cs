using System.Collections.Generic;
using Photon.Realtime;
using UnityEngine;
using TMPro;

public class LevelSystem : MonoBehaviour
{
    public static LevelSystem instance;

    public static TextMeshProUGUI uiLevelText;
    
    // A peut être mettre en private ?
    public static int level = 0;
    public static int experience;
    public static int experienceToNextLevel;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one LevelSystem in scene!");
            return;
        }

        instance = this;

        SetLevel(1);
    }

    public static bool AddExperience(int experienceToAdd)
    {
        experience += experienceToAdd;
        
        if (experience >= experienceToNextLevel)
        {
            SetLevel(level + 1);
            return true;
        }

        UpdateVisual();
        return false;
    }

    public static void SetLevel(int value)
    {
        level = value;
        experience = experience - experienceToNextLevel;
        experienceToNextLevel = (int)(50f * (Mathf.Pow(level + 1, 2) - (5 * (level + 1)) + 8));
        UpdateVisual();
    }

    public static void UpdateVisual()
    {
        uiLevelText.SetText(level.ToString("0") + "\nto next lvl: " + experienceToNextLevel + "\ncurrent exp: " + experience);
    }
}
