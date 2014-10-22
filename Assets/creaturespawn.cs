using UnityEngine;
using System.Collections;

public class creaturespawn : MonoBehaviour {
	public int maxc=1;
	public int val=0;
	public Transform prefab;
	public float x;
	public float y;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		x = Random.Range (-100f, 100f);
		y = Random.Range (-100f, 100f);
		if (((x * x) + (y * y) > 68f * 68f) ) {
					
			if(val<maxc){
				val+=1;
			Instantiate (prefab, new Vector3 (x, y, 0), Quaternion.identity);
			}
			
		
		}
	
		}
	public void subs(){
		val -= 1;

		}
}
