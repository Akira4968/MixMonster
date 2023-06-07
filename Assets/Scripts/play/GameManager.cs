using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int Stage =0;

    [SerializeField] List<GameObject> _Head;
    [SerializeField] List<GameObject> _Eye;
    [SerializeField] List<GameObject> _Mouth;
    [SerializeField] List<GameObject> _Hat;
    [SerializeField] List<GameObject> _Body;


    Vector2 startPosition = new Vector2(-1.7f, -1.7f);
    Vector2 pos = new Vector2(-1.7f, -1.7f);
    // Start is called before the first frame update
    void Start()
    {
        SpawnHead();
        SpawnEye();
        SpawnMouth();
        SpawnHat();
        SpawnBody();
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    public void SpawnHead()
    {
        
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
    public void SpawnEye()
    {

        int eye = 0;
        foreach (GameObject Eye in _Eye)
        {
            GameObject go = Instantiate(Eye);
            go.transform.position = startPosition;
            go.SetActive(false);
            eye++;
            startPosition += (Vector2.right * 1.15f);
            if (eye > 3)
            {
                eye = 0;
                startPosition = pos + Vector2.down;
            }
        }
    }
    public void SpawnMouth()
    {
        int mouth = 0;
        foreach( GameObject Mouth in _Mouth)
        {
            GameObject go = Instantiate(Mouth);
            go.transform.position = startPosition;
            go.SetActive(false);
            mouth++;
            startPosition += (Vector2.right * 1.15f);
            if(mouth > 3)
            {
                mouth = 0;
                startPosition = pos + Vector2.down;
            }
        }
    }
    public void SpawnHat()
    {
        int hat = 0;
        foreach(GameObject Hat in _Hat)
        {
            GameObject go = Instantiate(Hat);
            go.transform.position = startPosition;
            go.SetActive(false);
            hat++;
            startPosition += (Vector2.right * 1.15f);
            if(hat > 3)
            {
                hat = 0;
                startPosition = pos + Vector2.down;
            }
        }
    }
    public void SpawnBody()
    {
        int body = 0;
        foreach(GameObject Body in _Body)
        {
            GameObject go = Instantiate(Body);
            go.transform.position = startPosition;
            go.SetActive(false);
            body++;
            startPosition += (Vector2.right * 1.15f);
            if(body > 3)
            {
                body = 0;
                startPosition = pos + Vector2.down;
            }
        }
    }
    
}
