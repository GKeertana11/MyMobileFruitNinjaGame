using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchScript : MonoBehaviour
{
    public GameObject prefab;

    public GameObject particle;
    public Text scoretext;
    public int score=0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //We transform the touch position from screen space to world space.
            Vector3 touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);
        
           
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);//Sending a raycast from touch position.
            if (hitInformation.collider != null)//if raycast hits any collider
            {
                
                GameObject touchedObject = hitInformation.transform.gameObject;//This is the object which got hit by the raycast.
                //touchedObject should be the object someone touched.
                Debug.Log("Touched " + touchedObject.transform.name);//Priting name of the object
                if (touchedObject.tag == "Fruit")//If tag name of the object which got hit by raycast is fruit
                {
                    Destroy(touchedObject);//then fruit object is destroyed
                    score = score + 1;//score gets updated
                    scoretext.GetComponent<Text>().text = score.ToString();
                    GameObject temp = Instantiate(prefab, touchedObject.transform.position, Quaternion.identity);//instantiating a particle effect at the position of fruit which got destroyed.
                    Destroy(temp, 1f);//Destroying particle effect after 1sec.
                }
                else if(touchedObject.tag == "Bomb")//if tag name of the object which got hit by raycast is bomb
                {
                    Destroy(touchedObject);//Bomb is destroyed
                    score = score -1;//score gets decreased by 1 if bomb is touched
                    scoretext.GetComponent<Text>().text = score.ToString();
                    GameObject temp = Instantiate(particle, touchedObject.transform.position, Quaternion.identity);//partcile effect at the position of bomb
                    Destroy(temp, 1f);//destroying particle effect after 1sec.
                }

            }
        }
    }

    }

