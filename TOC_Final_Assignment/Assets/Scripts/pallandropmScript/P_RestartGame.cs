﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class P_RestartGame : MonoBehaviour
{
    public GameObject Gameover;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Gameover.SetActive(false);
            SceneManager.LoadScene("PalandromeScene");

        }
    }
}
