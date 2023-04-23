using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public UIController UIController;
    public static int deathCount;

    void Start()
    {
        UIController.updateDeathUI(deathCount);
    }

    public void addDeath()
    {
        deathCount++;
        UIController.updateDeathUI(deathCount);
    }

    public string getDeaths()
    {
        return deathCount.ToString();
    }
}
