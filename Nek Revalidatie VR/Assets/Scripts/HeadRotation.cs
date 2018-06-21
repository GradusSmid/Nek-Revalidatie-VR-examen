﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadRotation : MonoBehaviour {

    public Transform target;
    public float angle;

    public GameObject text;
    public GameObject HighscoreText;

    public DataController dataController;

     void Awake()
    {
        dataController = FindObjectOfType<DataController>();
    }

    private void Update()
    {
        angle = Vector3.Angle(transform.position, target.position);

        text.GetComponent<TextMesh>().text = "Rotatie Hoofd: " + angle;

        HighscoreText.GetComponent<TextMesh>().text = "Hoogste meting: " + dataController.GetHighestScore();
    }
}
