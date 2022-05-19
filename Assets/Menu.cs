using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button play;
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(GameScene);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void GameScene()
    {
        SceneManager.LoadScene(1);
    }
}
