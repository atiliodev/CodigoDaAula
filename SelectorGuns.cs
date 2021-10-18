using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorGuns : MonoBehaviour
{
    public GunSystem[] guns = new GunSystem[1];

    public int nrGun;

    int nrguns;

    private void Start()
    {
        nrguns = guns.Length;
    }

    void Update()
    {
        GunsSelector();
    }

    void GunsSelector()
    {
        if (Input.GetKeyUp("v"))
        {
            nrGun--;   
        }
        if (Input.GetKeyUp("b"))
        {
            nrGun++;
        }
        
        for (int x =0; x < guns.Length; x++)
        {
            if(x == nrGun)
            {
                guns[nrGun].gameObject.SetActive(true);
            }
            else
            {
                guns[x].gameObject.SetActive(false);
            }
        }

        //Derectrizes Do Selecionador
        if (nrGun > nrguns - 1)
        {
            nrGun = 0;
        }

        if(nrGun < 0)
        {
            nrGun = nrguns - 1;
        }
    }
}
