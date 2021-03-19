using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ahajradino1_basicInteraction : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public GameObject videoPlayer;
    public Sprite[] sprites;
    public GameObject slike;
    public Image slika;
    public GameObject previous;
    public GameObject next;
    public GameObject historija;
    public GameObject historija2;
    int brojac;
    // Use this for initialization
    void Start() {
        brojac = 0;
        Button prevBtn = previous.GetComponent<Button>();
        prevBtn.onClick.AddListener(PreviousBtn);
        Button nextBtn = next.GetComponent<Button>();
        nextBtn.onClick.AddListener(NextBtn);
    }

    // Update is called once per frame
    void Update() {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            if (hit.collider.gameObject.name == "ahajradino1_playbutton")
            {
                videoPlayer.SetActive(true);
                StartCoroutine(WaitAndDestroy());
            } else if (hit.collider.gameObject.name == "Video1")
            {
                videoPlayer.SetActive(false);
            }
            if (hit.collider.gameObject.name == "ahajradino1_interior" && !slike.activeSelf)
            {
                slike.SetActive(true);
            } if (hit.collider.gameObject.name == "slika")
            {
                slike.SetActive(false);
            }
            if (hit.collider.gameObject.name == "ahajradino1_knjiga" && !historija.activeSelf)
            {
                historija.SetActive(true);
                historija2.SetActive(true);
            } else if (hit.collider.gameObject.name == "Historija1")
            {
                historija.SetActive(false);
                historija2.SetActive(false);
            }
        }
    }

    public IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(125);
        videoPlayer.SetActive(false);
    }

    public void NextBtn()
    {
        if (brojac == sprites.Length - 1)
            slika.sprite = sprites[brojac];
        else
        slika.sprite = sprites[++brojac % sprites.Length];
    }

    public void PreviousBtn()
    {
        if (brojac == 0)
            slika.sprite = sprites[0];
        else
            slika.sprite = sprites[--brojac % sprites.Length];
    }
}
