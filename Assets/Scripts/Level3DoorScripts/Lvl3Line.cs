using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3Line : MonoBehaviour
{
    public BoxController2Enabler boxController2Enabler;

    private LineRenderer lineRenderer;

    [SerializeField]
    private Texture[] textures;



    private int animationStep;

    [SerializeField]
    private float fps = 30f;

    private float fpsCounter;

    private Transform target;


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    public void AssignTarget(Vector3 startPosition, Transform newTarget)
    {
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, startPosition);
        target = newTarget;


    }

    private void Update()
    {

        if (boxController2Enabler.MagicLine == true)
        {
            //  this.GetComponent<LineRenderer>().enabled = true;

            //lineRenderer.SetPosition(1, target.position);
            var player = GameObject.Find("LightningRod");
            var magic = GameObject.Find("SelectableObject (1)");
            lineRenderer.SetPosition(0, player.transform.position);
            lineRenderer.SetPosition(1, magic.transform.position);

            fpsCounter += Time.deltaTime;
            if (fpsCounter >= 1f / fps)
            {
                animationStep++;
                if (animationStep == textures.Length)
                    animationStep = 0;

                lineRenderer.material.SetTexture("_MainTex", textures[animationStep]);

                fpsCounter = 0f;
            }
            else
            {
                // this.GetComponent<LineRenderer>().enabled = false;
            }
        }
    }
}
