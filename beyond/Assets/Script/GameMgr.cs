using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public GameObject Man = null;
    public GameObject Girl = null;

    public Button Select1 = null;
    public Button Select2 = null;

    public Transform MovePos;

    // Start is called before the first frame update
    void Start()
    {
        btnsetting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveMan()
    {
        Man.transform.DOMove(MovePos.position, 1.0f);
    }

    void MoveGirl()
    {
        Girl.transform.DOMove(MovePos.position, 1.0f);
    }

    void btnsetting()
    {
        Select1.onClick.AddListener(() =>  MoveMan());
        Select2.onClick.AddListener(() => MoveGirl());
    }
}
