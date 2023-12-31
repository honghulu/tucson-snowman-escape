﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public GameObject[] otherElements;

    public void unPause() {
        Time.timeScale = 1;
                for (int i = 0; i < otherElements.Length; i++) {
                    if (otherElements[i].GetComponent<Damageable>() != null &&
                            otherElements[i].GetComponent<Damageable>().enabled)
                    {
                        otherElements[i].SetActive(true);
                    } else if (otherElements[i].GetComponent<Damageable>() == null)
                    {
                        otherElements[i].SetActive(true);
                    }
                    
                }
                pauseMenuCanvas.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) {
            if (Time.timeScale == 0) {
                Time.timeScale = 1;
                for (int i = 0; i < otherElements.Length; i++) {
                    if (otherElements[i].GetComponent<Damageable>() != null &&
                            otherElements[i].GetComponent<Damageable>().enabled)
                    {
                        otherElements[i].SetActive(true);
                    }
                    else if (otherElements[i].GetComponent<Damageable>() == null)
                    {
                        otherElements[i].SetActive(true);
                    }
                }
                pauseMenuCanvas.SetActive(false);
            } else {
                Time.timeScale = 0;
                for (int i = 0; i < otherElements.Length; i++) {
                    otherElements[i].SetActive(false);
                }
                pauseMenuCanvas.SetActive(true);
            }
        }
    }
}
