using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    #region PUBLIC VARIABLES
    
    public GameObject alertReference;
    #endregion
    #region PRIVATE VARIABLES
    private Text timeTF;
    #endregion

    #region MONOBEHAVIOUR BETHODS
    // Start is called before the first frame update
    void Start()
    {
        timeTF = gameObject.GetComponent<Text>();
        InvokeRepeating("ReduceTime", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    void ReduceTime()
    {
        if (timeTF.text == "1")
        {
            /* Alert */

            Time.timeScale = 0;
           // Instantiate(alertReference, new Vector3(0.5f, 0.5f, 0), transform.rotation);
            //audio.Play();
            // GameObject.Find("AppleGUI").GetComponent<AudioSource>().Stop();
            alertReference.SetActive(true);
        }

       timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
    }
    void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
