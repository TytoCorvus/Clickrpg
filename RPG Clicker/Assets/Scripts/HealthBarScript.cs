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
		currentHPRatio = 1f;
	    
	}
	
	// Update is called once per frame
	void Update () {
		currentHealthBar.transform.localScale = new Vector3(currentHPRatio, 1f, 1f);
		UpdateColor();
		
	}
	
	public void SetHealthRatio(float ratio){
		currentHPRatio = ratio;
		
	}
	
	public void UpdateColor(){
		if(currentHPRatio > .6f){
			currentHealthBar.color = new Vector4(0.0f, currentHPRatio, 0.0f, 1.0f);
		}
		else if(currentHPRatio > .3f){
			currentHealthBar.color = new Vector4(1f - (3 * currentHPRatio), currentHPRatio * currentHPRatio, 0.0f, 1.0f);
		}
		else{
			currentHealthBar.color = new Vector4(1.0f, 0f, 0f, 1f);
		}
	}
}
