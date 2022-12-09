using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMgr : MonoBehaviour
{
    public Button GameStartBtn = null;

    // Start is called before the first frame update
    void Start()
    {
        GameStartBtn.onClick.AddListener(() => StartCoroutine(GameStart()));
    }

    IEnumerator GameStart()
    {
        yield return null;
        SoundManager.In.PlaySoundClip("Click", ESoundType.SFX);

        SceneManager.LoadScene(1);
    }
}
