using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMono<GameManager>
{
    [SerializeField]
    public int OpenSituation = 2;
    private void Start()
    {
        SoundManager.In.PlaySoundClip("BGM", ESoundType.BGM, 1, 1);
        Screen.SetResolution(600, 1233, true);
    }
}
