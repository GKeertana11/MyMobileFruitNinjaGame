using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    
    private Vector3 randomPos;
    private Text scoreReference;

    void Start()
    {
        randomPos = new Vector3(Random.Range(-1, 1), Random.Range(0.3f, 0.7f), Random.Range(-6.5f, -7.5f));
        scoreReference = GameObject.Find("Score").GetComponent<Text>();
    }

    void Update()
    {
        /* Remove fruit if out of view */
        if (gameObject.transform.position.y < -36)
        {
            Destroy(gameObject);
        }
    }

   
}