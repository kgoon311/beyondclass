using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBase : MonoBehaviour
{
    public GameObject Panel = null;
    public GameObject SuccesPanel = null;
    public GameObject FailPanel = null;

    public Button PanelOut = null;
    public Button S_PanelOut = null;
    public Button F_PanelOut = null;
    public Button Select1 = null;
    public Button Select2 = null;

    void Start()
    {
        btnsetting();
    }
    void SceneStart()
    {
        Panel.SetActive(false);
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
    void btnsetting()
    {
        PanelOut.onClick.AddListener(() => SceneStart());
        S_PanelOut.onClick.AddListener(() => Restart());
        F_PanelOut.onClick.AddListener(() => Restart());
        Select1.onClick.AddListener(() => StartCoroutine(ActionButton1()));
        Select2.onClick.AddListener(() => StartCoroutine(ActionButton2()));
    }
    protected virtual IEnumerator ActionButton1()
    {
        yield return new WaitForSeconds(1.0f);
        SoundManager.In.PlaySoundClip("Clear", ESoundType.SFX, 1, 1);
        SuccesPanel.SetActive(true);
    }
    protected virtual IEnumerator ActionButton2() {
        yield return new WaitForSeconds(1.0f);

        SoundManager.In.PlaySoundClip("fail", ESoundType.SFX, 1, 1);
        FailPanel.SetActive(true);
    }
}
