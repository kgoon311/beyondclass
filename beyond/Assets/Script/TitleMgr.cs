using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMgr : MonoBehaviour
{
    public Button GameStartBtn = null;

    // Start is called before the first frame update
    void Start()
    {
        GameStartBtn.onClick.AddListener(() => GameStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameStart()
    {
        SceneManager.LoadScene(1);
    }
}
