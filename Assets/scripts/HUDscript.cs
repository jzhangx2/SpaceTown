﻿using UnityEngine;
using System.Collections;

public class HUDscript : MonoBehaviour {
	//string display;
	string text;
	
	//player object with weaponscript
	public GameObject player;
	
	void Update() {
		text = "";
		text += "$ " + player.GetComponent<weaponScript>().hp;
		text += "    Prime: " + player.GetComponent<weaponScript>().gunPrime;
		text += "\nGun: " + player.GetComponent<weaponScript>().revolverMode; 
		text += " " + player.GetComponent<weaponScript>().revolverAmmo + " x <==|";
		text += "\nWeapon: " + (int) player.GetComponent<weaponScript>().weaponCounter + " ";
		text += " TYPE: " + player.GetComponent<weaponScript>().specialWeapon + " ";
		text += player.GetComponent<weaponScript>().specialAmmo + " x ||";
		
		GetComponent<TextMesh>().text = text;
	}
}