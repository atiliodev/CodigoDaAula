using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    public Color whiteColor = Color.white;
    public Color redColor = Color.red;
    public Image targetImage;
    public TargetTriggerSet targetTrigger;
    [Space(20)]
    public float maxDistance = 12;
    public float minDistance = 3;

    private Canvas canvasSet;
    private float planeDistance;

    private void Start()
    {
        canvasSet = GetComponent<Canvas>();
    }

    private void Update()
    {
        if (targetTrigger.isHumanoid)
        {
            targetImage.color = redColor;
        }
        else
        {
            targetImage.color = whiteColor;
        }
        TargetConfig();
    }


    void TargetConfig()
    {
        if(inCollider == 1 && planeDistance > minDistance)
        {
            planeDistance -= Time.deltaTime * 2.5f;
        }
        else if(planeDistance < maxDistance)
        {
            planeDistance += Time.deltaTime * 3.5f;
        }
        canvasSet.planeDistance = planeDistance;
        //Directrizes do planeDistance
        if(planeDistance <= minDistance)
        {
            planeDistance = minDistance;
        }
        if(planeDistance >= maxDistance)
        {
            planeDistance = maxDistance;
        }
    }


    int inCollider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player")
        {
            inCollider = 1;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        inCollider = 0;
    }
}
