using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class DateSituation5 : MonoBehaviour
{
    public Text ManChatBox;
    public Text GirlChatBoxs;

    public GameObject Panel = null;
    public GameObject SuccesPanel = null;
    public GameObject FailPanel = null;

    public Button Select1 = null;
    public Button Select2 = null;
    public Button PanelOut = null;

    // Start is called before the first frame update
    void Start()
    {
        btnsetting();
    }

    IEnumerator Select1Show()
    {
        yield return null;
        SoundManager.In.PlaySoundClip("fail", ESoundType.SFX);

        ManChatBox.text = "가자!";
        yield return new WaitForSeconds(0.5f);
        GirlChatBoxs.text = "음..응..";

        yield return new WaitForSeconds(2.0f);

        FailPanel.SetActive(true);
    }

    IEnumerator Select2Show()
    {
        yield return null;
        SoundManager.In.PlaySoundClip("Clear", ESoundType.SFX);

        ManChatBox.text = "다른데 갈까?";
        yield return new WaitForSeconds(0.5f);
        GirlChatBoxs.text = "그랭!";

        yield return new WaitForSeconds(2.0f);

        SuccesPanel.SetActive(true);
    }

    void SceneStart()
    {
        SoundManager.In.PlaySoundClip("Click", ESoundType.SFX);

        Panel.SetActive(false);
    }

    void btnsetting()
    {
        PanelOut.onClick.AddListener(() => SceneStart());

        Select1.onClick.AddListener(() => StartCoroutine(Select1Show()));
        Select2.onClick.AddListener(() => StartCoroutine(Select2Show()));
    }

    public void GoMainScene()
    {
        SoundManager.In.PlaySoundClip("Click", ESoundType.SFX);

        SceneManager.LoadScene(0);
    }
}
