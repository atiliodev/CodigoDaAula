using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{
    public TextMeshProUGUI textGun;
    public TextMeshProUGUI textNumberBullets;
    public SelectorGuns guns;

    private int nrBullets;
    private string typeGun;


    void Update()
    {
        nrBullets = guns.guns[guns.nrGun].nrBullets;
        typeGun = guns.guns[guns.nrGun].gameObject.name;

        textGun.text = typeGun;
        textNumberBullets.text = " " + nrBullets;
    }
}
