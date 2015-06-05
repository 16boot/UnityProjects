using UnityEngine;
using System.Collections;

public class gerador : MonoBehaviour {
	
	public GameObject prefab;
	
	public GameObject[] postion;
	
	// Use this for initialization
	void Start () {
		
		int random = Random.Range(0,6);
		
		print(random);
		
		if(random == 0 || random == 2){
		Instantiate(prefab,postion[0].transform.position,Quaternion.identity);
		
		}else if(random == 3){
		Instantiate(prefab,postion[1].transform.position,Quaternion.identity);
		
		}else if(random == 4){
		Instantiate(prefab,postion[2].transform.position,Quaternion.identity);
		
		}else{
		Instantiate(prefab,postion[3].transform.position,Quaternion.identity);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
