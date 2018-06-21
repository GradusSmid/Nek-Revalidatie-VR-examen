using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLine : MonoBehaviour {

    public AudioSource aNote;
    public AudioSource cNote;
    public AudioSource eNote;
    public AudioSource dNote;
    public AudioSource gNote;
    public Transform radialProgress;

    public AudioSource Song;

    private GameObject musicSource;

    private void Update()
    {
        GameObject musicSource = GameObject.FindWithTag("Note");
        if (musicSource == null && Song.isPlaying == false)
        {
            Debug.Log("Play song");
            Song.Play();

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "A note")
        {
            aNote.Play();
            Destroy(col.gameObject);
            radialProgress.GetComponent<Image>().fillAmount = 0;
        }

        if (col.gameObject.name == "C note")
        {

            cNote.Play();
            Destroy(col.gameObject);
            radialProgress.GetComponent<Image>().fillAmount = 0;
        }

        if (col.gameObject.name == "D note")
        {
            dNote.Play();
            Destroy(col.gameObject);
            radialProgress.GetComponent<Image>().fillAmount = 0;
        }

        if (col.gameObject.name == "E note")
        {
            eNote.Play();
            Destroy(col.gameObject);
            radialProgress.GetComponent<Image>().fillAmount = 0;
        }

        if (col.gameObject.name == "G note")
        {
            gNote.Play();
            Destroy(col.gameObject);
            radialProgress.GetComponent<Image>().fillAmount = 0;
        }
    }
}
