using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahajradino1_ShowClick : MonoBehaviour {
    public GameObject poiKnjiga;
    public GameObject poiKamera;
    public GameObject poiPlaybtn;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        poiKnjiga.SetActive(true);
        poiKamera.SetActive(true);
        poiPlaybtn.SetActive(true);
    }

    public void hidePanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void showButton(GameObject exitBtn)
    {
        exitBtn.SetActive(true);
    }

    public void hideBtn(GameObject showBtn)
    {
        showBtn.SetActive(false);
    }
}
