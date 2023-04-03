using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideAndUnhide : MonoBehaviour 
{
    public GameObject bean;
    public GameObject lacis;
    public GameObject oma;
    public GameObject masina;
    public GameObject PaKreisi;
    public GameObject PaLabi;
    public void BeanAttels(bool vertiba) 
    { 
        bean.SetActive(vertiba);
        PaKreisi.GetComponent<Toggle>().interactable = vertiba;
        PaLabi.GetComponent<Toggle>().interactable = vertiba;
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


    public void UzKreiso ()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }

    public void UzLabo()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }

}
