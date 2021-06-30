using System;
using System.Collections;
using System.Collections.Generic;
using Helper;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Move : MonoBehaviour
{
    [HideInInspector] public PlayerDirection direction;
    
    [HideInInspector] public float stepLength = 1.25f;
    
    [HideInInspector] public float movementFrequency = 0.1f;
    private float _counter;
    private bool _move;
    
    [SerializeField] private GameObject _tail;

    private List<Vector3> _deltaPosition;

    private List<Rigidbody> _nodes;

    private Rigidbody _mainBody;
    private Rigidbody _headBody;
    private Transform _transform;

    public bool _createNodeAtTail;

    private void Awake()
    {
        _transform = transform;
        _mainBody = GetComponent<Rigidbody>();
        
        InitSnakeNodes();
        InitPlayer();

        _deltaPosition = new List<Vector3>()
        {
            new Vector3(-stepLength, 0f,0f),
            new Vector3(0f, 0f, stepLength),
            new Vector3(stepLength, 0f,0f),
            new Vector3(0f, 0f, -stepLength)
        };
    }

    private void Update()
    {
        CheckMovementFrequency();
    }

    private void FixedUpdate()
    {
        if (_move)
        {
            _move = false;
            
            MoveSnake();
        }
    }

    private void InitSnakeNodes()
    {
        _nodes = new List<Rigidbody>();
        
        _nodes.Add(_transform.GetChild(0).GetComponent<Rigidbody>());
        _nodes.Add(_transform.GetChild(1).GetComponent<Rigidbody>());
        _nodes.Add(_transform.GetChild(2).GetComponent<Rigidbody>());

        _headBody = _nodes[0];
    }

    void SetDirectionRandom()
    {
        int dirRandom = Random.Range(0, (int) PlayerDirection.COUNT);
        direction = (PlayerDirection)dirRandom;
    }
    private void InitPlayer()
    {
        SetDirectionRandom();
        
        switch (direction)
        {
            case PlayerDirection.RIGHT:
                _nodes[1].position = _nodes[0].position - new Vector3(Metrics.NODE, 0f, 0f);
                _nodes[2].position = _nodes[0].position - new Vector3(Metrics.NODE * 2f, 0f, 0f);
                
                break;
            case PlayerDirection.LEFT:
                _nodes[1].position = _nodes[0].position + new Vector3(Metrics.NODE, 0f, 0f);
                _nodes[2].position = _nodes[0].position + new Vector3(Metrics.NODE * 2f, 0f, 0f);

                break;
            case PlayerDirection.UP:
                _nodes[1].position = _nodes[0].position - new Vector3( 0f,0f,Metrics.NODE);
                _nodes[2].position = _nodes[0].position - new Vector3(0f,0f,Metrics.NODE * 2f);

                break;
            case PlayerDirection.DOWN:
                _nodes[1].position = _nodes[0].position + new Vector3( 0f,0f,Metrics.NODE);
                _nodes[2].position = _nodes[0].position + new Vector3(0f,0f,Metrics.NODE * 2f);

                break;
        }
    }

    private void MoveSnake()
    {
        Vector3 dPosition = _deltaPosition[(int) direction];

        Vector3 parentPos = _headBody.position;
        Vector3 prevPosition;

        _mainBody.position = _mainBody.position + dPosition;
        _headBody.position = _headBody.position + dPosition;

        for (int i = 1; i < _nodes.Count; i++)
        {
            prevPosition = _nodes[i].position;

            _nodes[i].position = parentPos;
            parentPos = prevPosition;
        }

        if (_createNodeAtTail)
        {
            _createNodeAtTail = false;

            GameObject newNode = Instantiate(_tail, _nodes[_nodes.Count-1].position,
                transform.rotation.normalized);
            
            newNode.transform.SetParent(transform, true);
            _nodes.Add(newNode.GetComponent<Rigidbody>());
        }
    }

    private void CheckMovementFrequency()
    {
        _counter += Time.deltaTime;
        if (_counter >= movementFrequency)
        {
            _counter = 0f;
            _move = true;
        }
    }

    public void SetInputDirection(PlayerDirection dir)
    {
        if (dir == PlayerDirection.UP & direction == PlayerDirection.DOWN ||
            dir == PlayerDirection.DOWN & direction == PlayerDirection.UP ||
            dir == PlayerDirection.LEFT & direction == PlayerDirection.RIGHT ||
            dir == PlayerDirection.RIGHT & direction == PlayerDirection.LEFT)
        {
            return;
        }

        direction = dir;

        ForceMove();
    }

    private void ForceMove()
    {
        _counter = 0;
        _move = false;
        MoveSnake();
    }
}
