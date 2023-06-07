using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillScenes : MonoBehaviour
{
    [SerializeField]SpriteRenderer _renderer;
    Camera _camera;
    // Start is called before the first frame update
    private void Awake()
    {
        _camera = Camera.main;
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        updateFillScene();
    }
    public void updateFillScene()
    {
        var height = _camera.orthographicSize * 2;
        var width = height * Screen.width / Screen.height;

        var aspect = (float)Screen.width / Screen.height;
        var imgAspect = _renderer.sprite.bounds.extents.x / _renderer.sprite.bounds.extents.y;

        if (aspect >= imgAspect)
        {
            transform.localScale = Vector3.one * width / (2 * _renderer.sprite.bounds.extents.x);
        }
        else
        {
            transform.localScale = Vector3.one * height / (2 * _renderer.sprite.bounds.extents.y);
        }
    }
}
