using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text deathCountTxt;

    public void updateDeathUI(int newDeaths)
    {
        deathCountTxt.text = "Deaths: " + newDeaths.ToString();
    }
}
