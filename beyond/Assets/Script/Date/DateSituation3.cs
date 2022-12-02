using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class DateSituation3 : MonoBehaviour
{
    public GameObject MoveMan;
    public GameObject MoveGirl;

    public Vector2 ManOrignPos;
    public Vector2 GirlOrignPos;

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

        ManOrignPos = MoveMan.transform.position;
        GirlOrignPos = MoveGirl.transform.position;
    }

    IEnumerator Select1Show()
    {
        yield return null;

        MoveMan.transform.DOMove(GirlOrignPos, 0.7f);
        MoveGirl.transform.DOMove(ManOrignPos, 0.7f);

        yield return new WaitForSeconds(1.0f);

        MoveMan.transform.DOMove(GirlOrignPos + new Vector2(0, 9.0f), 2f);
        MoveGirl.transform.DOMove(ManOrignPos + new Vector2(0, 9.0f), 2f);

        yield return new WaitForSeconds(2.5f);

        SuccesPanel.SetActive(true);
    }

    IEnumerator Select2Show()
    {
        yield return null;

        MoveMan.transform.DOMove(ManOrignPos + new Vector2(0, 9.0f), 2f);
        MoveGirl.transform.DOMove(GirlOrignPos + new Vector2(0, 9.0f), 2f);

        yield return new WaitForSeconds(2.5f);

        FailPanel.SetActive(true);
    }

    void SceneStart()
    {
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
        SceneManager.LoadScene(0);
    }
}
