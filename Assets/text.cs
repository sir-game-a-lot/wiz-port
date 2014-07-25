using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {

	GameObject cube;
	bar bar1;
	void  Start (){
		cube=GameObject.FindGameObjectWithTag("energy");
		bar1=cube.GetComponent<bar>();
	}
	
	void  Update (){
		guiText.text=bar1.score.ToString();
	}
}
