using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Fruits;
    public float throwForce;
    public float time;

    void Start()
    {
        
       
    }

    void Update()
    {

        
        time = time + Time.deltaTime;
        if(time>5f)
      foreach(GameObject item in Fruits)
        {
            GameObject fruit = Instantiate(item, new Vector3(Random.Range(-6.6f, 6.6f), Random.Range(-8.0f, -1.0f),0.0f), Quaternion.identity) as GameObject;
             fruit.GetComponent<Rigidbody2D>().AddForce(Vector2.up*throwForce, ForceMode2D.Impulse);
                time = 0f;
           // fruit.GetComponent<Rigidbody2D>().AddForce(Vector2.up*throwForce*Time.deltaTime);
        }
    }
}
