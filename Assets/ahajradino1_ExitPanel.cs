using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahajradino1_ExitPanel : MonoBehaviour {
    public GameObject poiKnjiga;
    public GameObject poiKamera;
    public GameObject poiPlaybtn;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        poiKnjiga.SetActive(false);
        poiKamera.SetActive(false);
        poiPlaybtn.SetActive(false);
    }

    public void hidePanel(GameObject panel)
    {
        panel.SetActive(false);
 

    //    btn.SetActive(true);
    }

    public void showButton(GameObject showBtn)
    {
        showBtn.SetActive(true);
    }

    public void hideBtn(GameObject exitBtn)
    {
        exitBtn.SetActive(false);
    }
}
