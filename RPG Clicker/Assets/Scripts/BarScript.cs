using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

	[SerializeField] public Vector4 color;
	[SerializeField] public bool isSolidColor;
	[SerializeField] public float startRatio;
	
	private float testTime = 1f;
	
	private Image currentBar;
	private Image flashingBar;
	public float currentRatio;
	
	
	
	// Use this for initialization
	void Start () {
		Transform bar = transform.Find("CurrentBar");
		currentBar = bar.GetComponent<Image>();
		
		if(startRatio != null){
			currentRatio = startRatio;
		}
		else{ currentRatio = 1f;}
		
		if(isSolidColor){currentBar.color = new Color32((byte)color.x, (byte)color.y, (byte)color.z, (byte)color.w);}
	}
	
	// Update is called once per frame
	void Update () {
		currentBar.transform.localScale = new Vector3(currentRatio, 1f, 1f);
		UpdateColor();
	}

	public void SetRatio(float ratio){
		currentRatio = ratio;
	}
	
	public void UpdateColor(){
		if(!isSolidColor){
			if(currentRatio > .6f){
				currentBar.color = new Vector4(0.0f, currentRatio, 0.0f, 1.0f);
			}
			else if(currentRatio > .3f){
				currentBar.color = new Vector4(1f - (3 * currentRatio), currentRatio * currentRatio, 0.0f, 1.0f);
			}
			else{
				currentBar.color = new Vector4(1.0f, 0f, 0f, 1f);
			}
		}
        else{currentBar.color = new Color32((byte)color.x, (byte)color.y, (byte)color.z, (byte)color.w);}

	}
}

