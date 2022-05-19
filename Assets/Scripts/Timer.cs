using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    #region PUBLIC VARIABLES
    public float time;
    public int timescore = 60;
    public GameObject Gameover;
    #endregion

    #region PRIVATE VARIABLES
    private Text timetext;
    #endregion

    #region MONOBEHAVIOUR BETHODS
    // Start is called before the first frame update
    void Start()
    {
        timetext= gameObject.GetComponent<Text>();
       // InvokeRepeating("ReduceTime", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 1f)
        {
            timescore--;

            if (timescore == 0)
            {
                Gameover.SetActive(true);
            }
            else
            {
                timetext.text = timescore.ToString();
                time = 0f;
            }
        }
    }

    #endregion
}
  
