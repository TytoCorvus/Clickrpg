using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

	private Image currentHealthBar;
	private Image flashingHealthBar;
	private float currentHPRatio;
	private bool lowHealth;
	
	
	// Use this for initialization
	void Start () {
		Transform currentBar = transform.Find("CurrentHealthBar");
		currentHealthBar = currentBar.GetComponent<Image>();
		Debug.Log("Instantiation Complete");
	    
	}
	
	// Update is called once per frame
	void Update () {
		
		if(currentHPRatio < .05){
			currentHPRatio -= .01;
		}
		currentHealthBar.rectTransform.localScale = new Vector3(currentHPRatio, 1f, 1f);
		
	}
	
	public void setHealthRatio(float ratio){
		currentHPRatio = ratio;
		
	}
}
