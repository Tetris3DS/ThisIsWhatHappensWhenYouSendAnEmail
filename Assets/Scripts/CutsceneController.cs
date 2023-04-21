using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject CutsceneCam;
    public GameObject PlayerCam;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (TheSequence());
    }
    IEnumerator TheSequence ()
    {
        yield return new WaitForSeconds(23);
        PlayerCam.SetActive(true);
        CutsceneCam.SetActive(false);
    }

}
