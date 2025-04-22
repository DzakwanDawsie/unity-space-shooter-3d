using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditOpen : MonoBehaviour {

	public GameObject creditPanel;

	
	// Update is called once per frame
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		CloseCreditPanel();
	}

	public void OpenCreditPanel () {
		creditPanel.SetActive(true);
	}

	public void CloseCreditPanel () {
		creditPanel.SetActive(false);
	}
}
