using UnityEngine;
using System.Collections;

public class bar : MonoBehaviour {

	public float countdown;
	public int aposition;
	public int score;
	public Vector3 xp;
	public GameObject bg;
	public SpriteRenderer rend;
	public float convrt;
	void  Start (){
		countdown=10.0f;
		aposition =1;
		score=0;
		rend=bg.GetComponent<SpriteRenderer>();
		
	}
	
	void  FixedUpdate (){
		
		if(countdown<=0.0f)
		{Application.LoadLevel("1");
		}
		else if(countdown>0.0f)
		{	convrt=(countdown/10);
			countdown-=Time.deltaTime;
			rend.color=new Color(convrt,convrt,convrt,1);
			xp=new Vector3(countdown/2,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
			gameObject.transform.localScale=xp;
		}
		
		
	}
	public void  add1 (){
		
		score+=1;
		if(countdown<=8){
			countdown+=2.0f;}
		
		
	}
	public void  flip (){if (aposition==1){
			aposition=-1;
		}
		else
		{aposition=1;
		}
		
	}
}
