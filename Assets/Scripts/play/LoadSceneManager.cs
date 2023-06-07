using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : MonoBehaviour
{
    [SerializeField] Slider _Loadding;
    // Start is called before the first frame update
    void Start()
    {
        _Loadding.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _Loadding.value += Time.deltaTime;
        if (_Loadding.value >= 5)
        {
            _Loadding.value = 5;
            SceneManager.LoadScene(1);
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(2);
    }
}
