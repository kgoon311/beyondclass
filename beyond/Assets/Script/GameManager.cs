using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMono<GameManager>
{
    [SerializeField]
    public int OpenSituation = 2;
    private void Start()
    {
        SoundManager.In.PlaySoundClip("BGM", ESoundType.BGM, 1, 1);

    }
}
