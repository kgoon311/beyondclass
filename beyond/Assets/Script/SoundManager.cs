using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum ESoundType
{
    BGM,
    SFX,
    End
}
public class AudioSourceClass
{
    public AudioSource audiosource;
    public float audioVolume;
}
public class SoundManager : SingletonMono<SoundManager>
{
    [Header("Sounds")]
    [SerializeField]
    private List<AudioClip> BGM = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> SFX = new List<AudioClip>();

    public bool bgmmute;
    public bool sfxmute;

    //������� �̸����� �з��� �ִ� Dictionary
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();
    //��������� Ÿ�Կ� ���� AudioSource�� �ִ� Dictionary
    private Dictionary<ESoundType, AudioSourceClass> audioSourceClasses = new Dictionary<ESoundType, AudioSourceClass>();

    //�����Ҷ� ���带 ��ųʸ��� �߰�����
    protected override void OnAwake()
    {
        //Resources���� �ȿ� Sounds���� �ȿ� �ִ�  AudioClip�� ���� �����´�
        AudioClip[] clips = Resources.LoadAll<AudioClip>("Sounds/");
        //������ AudioClips�� Dictionary�� �߰�
        foreach (AudioClip clip in clips)
        {
            audioClips[clip.name] = clip;
        }
        //Enum�� �̸��� string���� ��ȯ����
        string[] enumNames = Enum.GetNames(typeof(ESoundType));

        //���ӿ�����Ʈ�� ����� Ŭ��������ŭ �����ϰ� ����� Ŭ������ �׿� �´� �ڽ� ������Ʈ�� �����Ѵ�
        for (int i = 0; i < (int)ESoundType.End; i++)
        {
            GameObject AudioSourceobj = new GameObject(enumNames[i]);
            AudioSourceobj.transform.SetParent(transform);
            AudioSourceClass sourceClass
                = new AudioSourceClass
                { audiosource = AudioSourceobj.AddComponent<AudioSource>(), audioVolume = 0.5f };
            audioSourceClasses[(ESoundType)i] = sourceClass;
        }

        audioSourceClasses[ESoundType.BGM].audiosource.loop = true;
    }

    /// <summary>
    /// ���� �������µ� �������� ��Ҹ� �־ �����´�
    /// </summary>
    /// <param name="soundtype">BGM , SFX</param>
    /// <param name="name">���� ����</param>
    /// <param name="volume">����</param>
    /// <param name="pitch">��ġ</param>
    /// <returns></returns>
    public AudioClip PlaySoundClip(string clipname, ESoundType type, float volume = 0.5f, float pitch = 1)
    {
        AudioClip clip = audioClips[clipname];

        audioSourceClasses[type].audiosource.clip = clip;
        audioSourceClasses[type].audiosource.volume = volume;
        audioSourceClasses[type].audiosource.pitch = pitch;

        if (type == ESoundType.BGM)//BGM
            audioSourceClasses[type].audiosource.Play();
        else//SFX
            audioSourceClasses[type].audiosource.PlayOneShot(clip);

        return clip;
    }
}