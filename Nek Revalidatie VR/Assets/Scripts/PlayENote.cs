using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayENote : MonoBehaviour {

    public float myTime = 0f;
    public Transform radialProgress;
    public AudioSource pianoTone;

    // Use this for initialization
    void Start()
    {
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }

    // Update is called once per frame
    void Update()
    {

        myTime += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = myTime / 1.5f;

        if (myTime >= 1.5f)
        {
            Debug.Log("E note");
            pianoTone.Play();
            Destroy(this.gameObject);
            Resetinator();
        }
    }

    public void Resetinator()
    {
        myTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }
}
