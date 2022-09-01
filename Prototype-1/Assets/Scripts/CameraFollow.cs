using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 _cameraOffset;
    public GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {// sets the offset position of camera
        _cameraOffset = new Vector3(1,8,-11);
     // camera follows player
        transform.position = _player.transform.position + _cameraOffset;
    }
}
