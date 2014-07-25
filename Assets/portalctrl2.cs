using UnityEngine;
using System.Collections;

public class portalctrl2 : MonoBehaviour {
	public float countdown;
	public float countdownc;
	public SpriteRenderer rend;
	public GameObject cube;
	public bar bar1;
	public SpriteRenderer rendb;
	public Vector3 pp;
	void  Start (){
		countdown=0.0f;
		countdownc=Random.Range(0,3);
		rend=gameObject.GetComponent<SpriteRenderer>();
		cube=GameObject.FindGameObjectWithTag("energy");
		bar1=cube.GetComponent<bar>();
	}
	
	void  FixedUpdate (){
		if(bar1.aposition==1){
			if(countdown<=0.0f)
			{
				rend.color= new Color(.5f,.5f,.5f,.5f);
				gameObject.transform.collider2D.isTrigger=false;
				
				
				if(countdownc<=0.0f)
				{
					countdown=1.0f;
				}
				else if(countdownc>0.0f)
				{countdownc-=Time.deltaTime;
				}
				
				
				
			}
			
			
			else if(countdown>0.0f)
			{
				rend.color=new Color(1,1,1,1);
				gameObject.transform.collider2D.isTrigger=true;
				countdown-=Time.deltaTime;
				countdownc=Random.Range(0,3);
			}
		}
		else{
			rend.color= new Color(.5f,.5f,.5f,.5f);
			gameObject.transform.collider2D.isTrigger=false;
			countdown=0;
		}
		
		
		
		
	}
	void  OnTriggerEnter2D ( Collider2D collider  ){
		pp = new Vector3(collider.transform.position.x,collider.transform.position.y - 1.5f,collider.transform.position.z);
		collider.transform.position=pp;
		bar1.add1();
		bar1.flip();
		
	}
	void  OnCollisionEnter2D ( Collision2D col  ){
		if(col.gameObject.tag == "Player")
		{
			rendb = col.gameObject.GetComponent<SpriteRenderer>();
			rendb.color= new Color(.3f,.4f,.2f,1f);
			
			Application.LoadLevel("1");}
	}
}
