using UnityEngine;
using System.Collections;

public class lookat: MonoBehaviour {
	public Transform target;
	public Vector3 dir;
	public int vel=0;
	public GameObject cube;
	public creaturespawn csn;
	void Start(){
		cube = GameObject.FindGameObjectWithTag ("spawn");
		csn = cube.GetComponent<creaturespawn>();
		dir = target.position - transform.position;
		dir.Normalize ();
		}
	void Update() {



		transform.position += dir * vel * Time.deltaTime;
		if ((Mathf.Abs(transform.position.x-target.position.x)<0.5)&&(Mathf.Abs(transform.position.y-target.position.y)<0.5)) {
			csn.subs();
			Destroy(gameObject);	}
		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
	void OnMouseDown()
	{
		csn.subs ();
		Destroy(gameObject);	
		
	}
}