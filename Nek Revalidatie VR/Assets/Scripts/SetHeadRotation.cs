﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHeadRotation : MonoBehaviour {

    public float myTime = 0f;
    public Transform radialProgress;
    public GameObject PlayGame;
    public DataController dataController;
    public HeadRotation headRotation;


    void Awake()
    {
        dataController = FindObjectOfType<DataController>();
        headRotation = FindObjectOfType<HeadRotation>();
    }

    void Update()
    {
        myTime += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = myTime / 1;

        if (myTime >= 1f)
        {
            PlayGame.SetActive(true);
            dataController.SubmitNewPlayerScore(headRotation.angle);
            Resetinator();
        }
    }

    public void Resetinator()
    {
        myTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }
}
