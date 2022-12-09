using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class DateSituation1 : MonoBehaviour
{
    public Text ManChatBox;

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
        SoundManager.In.PlaySoundClip("Clear", ESoundType.SFX);

        ManChatBox.text = Select1.GetComponentInChildren<Text>().text;
        yield return new WaitForSeconds(1.0f);

        SuccesPanel.SetActive(true);


    }

    IEnumerator Select2Show()
    {
        yield return null;
        SoundManager.In.PlaySoundClip("fail", ESoundType.SFX);

        ManChatBox.text = Select2.GetComponentInChildren<Text>().text;
        yield return new WaitForSeconds(1.0f);

        FailPanel.SetActive(true);
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
