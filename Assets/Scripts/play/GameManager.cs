using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] List<GameObject> _Head;
    [SerializeField] List<GameObject> _Eye;
    [SerializeField] List<GameObject> _Mouth;
    [SerializeField] List<GameObject> _Hat;
    [SerializeField] List<GameObject> _Body;
    // Start is called before the first frame update
    void Start()
    {
        SpawnHead();
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    public void SpawnHead()
    {
        Vector2 startPosition = new Vector2(-1.7f, -1.7f);
        Vector2 pos = new Vector2(-1.7f, -1.7f);
        int head = 0;
        foreach(GameObject Head in _Head)
        {
            GameObject go = Instantiate(Head);
            go.transform.position = startPosition;
            head++;
            startPosition += (Vector2.right * 1.15f);
            if(head > 3)
            {
                head = 0;
                startPosition = pos + Vector2.down;
            }
        }
    }
    
}
