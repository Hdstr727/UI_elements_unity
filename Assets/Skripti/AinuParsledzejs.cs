using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AinuParsledzejs : MonoBehaviour {

	public void UzSakumu()
	{
		SceneManager.LoadScene("Sakums");
	}

	public void Atpakal()
	{
		SceneManager.LoadScene("ui_aina");
	}
	
	public void Apturet()
	{
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
