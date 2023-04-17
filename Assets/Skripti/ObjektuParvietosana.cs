using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, 
	IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{
	public Canvas kanva;
	private RectTransform transjormacijasLogs;
	// Use this for initialization
	void Start () {
		transjormacijasLogs = GetComponent<RectTransform>();
	}

	public void OnPointerDown (PointerEventData notikums)
	{
		Debug.Log("Izdarits kreisais klikskis uz velkama objekta");
	}

	public void OnBeginDrag (PointerEventData notikums)
	{
		Debug.Log("Uzsakta objekta vilksana");
	}
	
	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek objekta vilksana");
		transjormacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums)
	{
		Debug.Log("Beigta objekta vilksana");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
