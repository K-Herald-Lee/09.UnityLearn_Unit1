using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject _player;
    private Vector3 _offset = new Vector3(0,7,-12);
    
    void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;        
    }
}
