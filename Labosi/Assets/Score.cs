using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text text;
    public int vrijednost = 0;
    public int brojBodovaZaLoptu=10;

	void Start () {
        text.text = "Score:\n" + vrijednost;
    }
	
	
	void Update () {
		
	}
}
