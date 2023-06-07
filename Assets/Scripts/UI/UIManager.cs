using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]Animator _sound;
    [SerializeField]Animator _music;
    [SerializeField] GameObject _settingpanel;
    [SerializeField] GameObject _UIManager;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sound()
    {
        _sound.SetBool("IsOn", !_sound.GetBool("IsOn"));
    }
    public void Music()
    {
        _music.SetBool("IsOn", !_music.GetBool("IsOn"));
    }
    public void CloseSetting()
    {
        _settingpanel.SetActive(false);
    }
    public void OpenSetting()
    {
        _settingpanel.SetActive(true);
    }
}
