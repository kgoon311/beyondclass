using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using UnityEditor;

[System.Serializable]
public class UnLockObj
{
    public Button UnLockBtn;
    public GameObject UnLockImg;
}

public class SelectStageMgr : MonoBehaviour
{
    public List<UnLockObj> UnLockObjs; 

    public List<SceneAsset> DateScene;
    public List<SceneAsset> CompanyScene;

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

    public void GoDateGame()
    {
        SoundManager.In.PlaySoundClip("Click", ESoundType.SFX);
        SceneManager.LoadScene(DateScene[Random.Range(0, DateScene.Count)].name);
    }

    public void GoCompanyGame()
    {
        SoundManager.In.PlaySoundClip("Click", ESoundType.SFX);
        SceneManager.LoadScene(CompanyScene[Random.Range(0, CompanyScene.Count)].name);
    }
}
