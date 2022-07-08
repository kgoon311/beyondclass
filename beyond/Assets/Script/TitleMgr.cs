using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMgr : MonoBehaviour
{
    public Button GameStartBtn = null;
    public GameObject FadePanel = null;

    // Start is called before the first frame update
    void Start()
    {
        GameStartBtn.onClick.AddListener(() => StartCoroutine(GameStart()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameStart()
    {
        yield return null;
        FadePanel.SetActive(true);
        FadePanel.GetComponent<Image>().DOFade(1, 1);
        yield return new WaitForSeconds(1.0f);         

        SceneManager.LoadScene(1);
    }
}
