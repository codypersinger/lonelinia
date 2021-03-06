﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]

public class PlayerHealth : MonoBehaviour {

	private int maximumHealth = 100;
	private int currentHealth = 100;

	private int barPositionX = 15;
	private int barPositionY = 15;
	private int barHeight = 24;
	private int barWidthDivisor = 4; //4 for 1/4 the screen width
	private float healthBarLength;


	void Awake () {
	}

	void Start () {
	}

	void Update () {
	}

	void OnGUI() {
		updateHealthBar (currentHealth, maximumHealth);
	}

	public void updatePlayerHealth(int healthChange) {

		currentHealth += healthChange;

		if (currentHealth < 0) {
			currentHealth = 0;
		}
		if (currentHealth > maximumHealth) {
			currentHealth = maximumHealth;
		}
		if (maximumHealth < 1) {
			maximumHealth = 1;
		}
	}

	private void updateHealthBar(int curHealth, int maxHealth) {
		float barWidth = (Screen.width / barWidthDivisor) * (curHealth / (float)maxHealth);
		GUI.Box (new Rect (barPositionX, barPositionY, barWidth, barHeight), curHealth + "/" + maxHealth);
	}

}