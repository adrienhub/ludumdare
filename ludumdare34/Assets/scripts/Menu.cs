﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GUISkin skinMenu;
	public Texture2D btnMenuPlay;
	public Texture2D titulo;
	public Texture2D btnVoltar;




	// Use this for initialization
	void Start () {
		
	}


	void OnGUI() {
		GUI.skin = skinMenu;
		GUI.DrawTexture(new Rect (Screen.width/2 - titulo.width/2, Screen.height/2 - titulo.height/2,titulo.width,titulo.height),titulo);

		bool play = GUI.Button (new Rect (Screen.width - 164, Screen.height-100,64,64),btnMenuPlay);
		bool sair = GUI.Button (new Rect (Screen.width - 100, Screen.height-100,64,64),btnVoltar);


		if (play) {
			SceneManager.LoadScene (1);
			Score.Inicializar();
		}

		if (sair) {
			Application.Quit();
			Debug.Log ("Saiu do jogo");
		}
	}
}
