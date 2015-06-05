using UnityEngine;
using System.Collections;

public class creditos : MonoBehaviour {
	
	public	string[] names; 
	public  int      position_y;
	
	private string returnElement;
	
	string ArrayItens(string[] array){
	
		 
		
		 for(int i = 0; i < names.Length; i++) {
       		returnElement += array[i] + "\n" ;
		
		 }
		
			return returnElement;
		
	}
	
	
	void OnGUI(){
	
	
		
		GUI.Box(new Rect(500,100,250,position_y), "Creditos " + "\n" + ArrayItens(names));
		
		if(GUI.Button(new Rect(500,100,50,50), " Voltar ")){
		
			Application.LoadLevel("menu");
		
		}
		
	}
	
}
