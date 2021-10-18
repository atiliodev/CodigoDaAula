using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTriggerSet : MonoBehaviour
{
    public bool isHumanoid;
    public float distance = 500f;
    public LayerMask layerMask;

    private void Update()
    {
        if (Physics.Linecast(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + (distance * 100)), layerMask))
        {
            isHumanoid = true;
        }
        else
        {
            isHumanoid = false;
        }
    }
}
