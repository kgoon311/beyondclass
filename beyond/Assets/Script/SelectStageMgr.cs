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
    public List<UnLockObj> UnLockObjs; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    IEnumerator StartScene()
    {
        for (int i = 0; i < GameManager.In.OpenSituation; i++)
        {
            UnLockObjs[i].UnLockImg.SetActive(false);
        }

        yield return null;
    }

    public void GoInGame()
    {
        SceneManager.LoadScene(2);
    }
}
