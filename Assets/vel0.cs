using UnityEngine;
using System.Collections;

public class vel0 : MonoBehaviour {
	GameObject pl;
	controller ctrl;
	
	void  Start (){
		pl=GameObject.FindGameObjectWithTag("Player");
		ctrl=pl.GetComponent<controller>();
		
		
	}
	void  OnTriggerEnter2D ( Collider2D collider  ){
		
		if(collider.tag == "Player") {
			
			collider.gameObject.rigidbody2D.gravityScale=0;
			collider.gameObject.rigidbody2D.velocity=new Vector2(0,0);
			
			
		}
		

		
		
	}
}
