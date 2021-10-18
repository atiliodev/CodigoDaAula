using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public Transform target;
    public GameObject bullet;
    [Space(20)]
    [Range(0.05f,5)] public float nextBulletTime = 0.1f;
    public int nrBullets = 100;
    public bool inShoot;
    public GameObject fire;
    public AudioSource audioBullets;
    bool wait;


    private void Update()
    {
        GunControler();
    }

    void GunControler()
    {
        if (nrBullets > 0 && Input.GetMouseButton(0))
        {
            audioBullets.enabled = true;
            fire.SetActive(true);
            inShoot = true;
            Shoot();
        }
        else
        {
            fire.SetActive(false);
            audioBullets.enabled = false;
            inShoot = false;
        }
    }

    void Shoot()
    {
        if(nrBullets > 0 && !wait)
        {
            Instantiate(bullet, target.position, target.rotation);
            nrBullets--;
            StartCoroutine("shootWait");
            wait = true;
        }
    }

    IEnumerator shootWait()
    {
        yield return new WaitForSeconds(nextBulletTime);
        wait = false;
    }

}
