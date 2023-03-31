using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndUnhide : MonoBehaviour {
    public GameObject bean;
    public GameObject lacis;
    public GameObject oma;
    public GameObject masina;
    
    public void BeanAttels(bool vertiba) { 
        bean.SetActive(vertiba);
    }

    public void LacisAttels(bool vertiba)
    {
        lacis.SetActive(vertiba);
    }

    public void OmaAttels(bool vertiba)
    {
        oma.SetActive(vertiba);
    }

    public void MasinaAttels(bool vertiba)
    {
        masina.SetActive(vertiba);
    }


}
