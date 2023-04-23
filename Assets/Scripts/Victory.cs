using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject victoryPanel;

    public PlayerData PlayerData;
    public TMP_Text YouWin;
    public TMP_Text TotalDeaths;

    private string continueSceneName;

    public void activateVictory(string nextSceneName)
    {
        continueSceneName = nextSceneName;
        InvokeRepeating("RandomMenuColor", 0.25f, 0.25f);
        TotalDeaths.text = "Total Deaths: " + PlayerData.getDeaths();
        victoryPanel.SetActive(true);
    }

    public void continueToScene()
    {
        SceneManager.LoadScene(continueSceneName);
    }

    string ColorToHex(Color32 color)
    {
        string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        return hex;
    }

    Color32 RandomColor()
    {
        return new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
    }

    void RandomMenuColor()
    {
        string Y = "<color=#" + ColorToHex(RandomColor()) + ">Y</color>";
        string o = "<color=#" + ColorToHex(RandomColor()) + ">o</color>";
        string u = "<color=#" + ColorToHex(RandomColor()) + ">u</color>";

        string W = "<color=#" + ColorToHex(RandomColor()) + ">W</color>";
        string i = "<color=#" + ColorToHex(RandomColor()) + ">i</color>";
        string n = "<color=#" + ColorToHex(RandomColor()) + ">n</color>";
        string excl = "<color=#" + ColorToHex(RandomColor()) + ">!</color>";

        YouWin.text = Y + o + u + " " + W + i + n + excl;
    }
}
