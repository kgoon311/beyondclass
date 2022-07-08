using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

[System.Serializable]
public class UnLockObj
{
    public Button UnLockBtn;
    public GameObject UnLockImg;
}

public class SelectStageMgr : MonoBehaviour
{
    public GameObject FadePanel = null;

    public List<UnLockObj> UnLockObjs; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartScene()
    {
        for (int i = 0; i < GameManager.In.OpenSituation; i++)
        {
            UnLockObjs[i].UnLockImg.SetActive(false);
        }

        yield return null;

        FadePanel.SetActive(true);
        FadePanel.GetComponent<Image>().DOFade(0, 1);
        yield return new WaitForSeconds(1);

        FadePanel.SetActive(false);
    }

    public void GoInGame()
    {
        SceneManager.LoadScene(2);
    }
}
