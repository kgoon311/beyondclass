using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public GameObject Man = null;
    public GameObject Girl = null;

    public GameObject Panel = null;
    public GameObject SuccesPanel = null;
    public GameObject FailPanel = null;

    public Button Select1 = null;
    public Button Select2 = null;
    public Button PanelOut = null;

    public Transform MovePos;

    public bool SituationResult = false;

    // Start is called before the first frame update
    void Start()
    {
        btnsetting();
    }

    IEnumerator MoveMan()
    {
        yield return null;

        Man.transform.DOMove(MovePos.position, 1.0f);
        yield return new WaitForSeconds(1.0f);

        FailPanel.SetActive(true);


    }

    IEnumerator MoveGirl()
    {
        yield return null;

        Girl.transform.DOMove(MovePos.position, 1.0f);
        yield return new WaitForSeconds(1.0f);

        SuccesPanel.SetActive(true);
    }

    void SceneStart()
    {
        Panel.SetActive(false);
    }

    void btnsetting()
    {
        PanelOut.onClick.AddListener(() => SceneStart());
        Select1.onClick.AddListener(() =>  StartCoroutine(MoveMan()));
        Select2.onClick.AddListener(() => StartCoroutine(MoveGirl()));
    }

    public void GoMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
