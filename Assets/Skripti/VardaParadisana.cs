using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {

	private string teksts;
	private string[] varianti = { "Sveiks ", "Jauku dienu! ", "Prieks tevi redzet! ", "Uzredzesanos " };

	int nejausais;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;

	public void UzglabatTekstu() {
		nejausais = Random.Range (0, varianti.Length);
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text = varianti[nejausais]+teksts.ToUpper()+"!";
	}

}
