using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class C_1 : GameBase
{
    public Sprite[] sprites;
    public SpriteRenderer BG;

    protected override IEnumerator ActionButton1()
    {
        BG.sprite = sprites[0];
        return base.ActionButton1();
    }
    protected override IEnumerator ActionButton2()
    {
        BG.sprite = sprites[1];
        return base.ActionButton2();
    }
}
