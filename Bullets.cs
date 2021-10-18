using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float TimeBullet = 20f;
    public float bulletVelocity = 15f;


    void Update()
    {
        TimeBullet -= Time.deltaTime * 1.5f;

        transform.Translate(0, 0, bulletVelocity * 50 * Time.deltaTime);

        if(TimeBullet <= 0)
        {
            Destroy(transform.gameObject, 0.001f);
        }
    }

    private void OnCollisionEnter()
    {
        Destroy(transform.gameObject, 0.001f);
    }
}
