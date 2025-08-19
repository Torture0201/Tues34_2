using System.Collections;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private enum PlayerStatus
    {
        frontIdle,
        backIdle,
        leftIdle,
        rightIdle,
        frontWalk,
        backWalk,
        leftWalk,
        rightWalk

    }
    [SerializeField, Header("���x")] private float _speed = 1f;
    [SerializeField, Header("�ړ���")] private float _width = 0.5f;

    private Animator _animator; 
    private GamePlayerInput _playerInput;
    // �v���C���[�X�e�[�^�X
    private PlayerStatus _playerStatus = PlayerStatus.frontIdle;
    // �ړ����t���O
    private bool _isWalking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerInput = new GamePlayerInput();
        _playerInput.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isWalking) return;
        var direction = _playerInput.Player.Move.ReadValue<Vector2>();
        // �E�ړ��̏ꍇ
        if (direction.x > 0)
        {
            if(_playerStatus != PlayerStatus.rightWalk)
            {
                _playerStatus = PlayerStatus.rightWalk;
                _animator.SetTrigger(PlayerStatus.rightWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.right));
        }
        // ���ړ��̏ꍇ
        else if (direction.x < 0)
        {
            if (_playerStatus != PlayerStatus.leftWalk)
            {
                _playerStatus = PlayerStatus.leftWalk;
                _animator.SetTrigger(PlayerStatus.leftWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.left));
        }
        // ��ړ��̏ꍇ
        else if (direction.y > 0)
        {
            if (_playerStatus != PlayerStatus.backWalk)
            {
                _playerStatus = PlayerStatus.backWalk;
                _animator.SetTrigger(PlayerStatus.backWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.up));
        }
        // ���ړ��̏ꍇ
        else if (direction.y < 0)
        {
            if (_playerStatus != PlayerStatus.frontWalk)
            {
                _playerStatus = PlayerStatus.frontWalk;
                _animator.SetTrigger(PlayerStatus.frontWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.down));
        }
        // �ړ����Ȃ��ꍇ
        else StopStatusCheck();
    }

    private void StopStatusCheck()
     {
        // ���O���O�ړ��Ȃ�΁A�O��~�A�j���[�V�����ɕύX
        if(_playerStatus == PlayerStatus.frontWalk)
        {
            _playerStatus = PlayerStatus.frontIdle;
            _animator.SetTrigger(PlayerStatus.frontIdle.ToString());
        }
        // ���O�����ړ��Ȃ�΁A����~�A�j���[�V�����ɕύX
        if (_playerStatus == PlayerStatus.backWalk)
        {
            _playerStatus = PlayerStatus.backIdle;
            _animator.SetTrigger(PlayerStatus.backIdle.ToString());
        }
        // ���O�����ړ��Ȃ�΁A����~�A�j���[�V�����ɕύX
        if (_playerStatus == PlayerStatus.leftWalk)
        {
            _playerStatus = PlayerStatus.leftIdle;
            _animator.SetTrigger(PlayerStatus.leftIdle.ToString());
        }
        // ���O���E�ړ��Ȃ�΁A�E��~�A�j���[�V�����ɕύX
        if (_playerStatus == PlayerStatus.rightWalk)
        {
            _playerStatus = PlayerStatus.rightIdle;
            _animator.SetTrigger(PlayerStatus.rightIdle.ToString());
        }
    }


    /// <summary>
    /// �L�����N�^�[�̈ړ�
    /// </summary>
    /// <param name="direction">�ړ�����</param>
    /// <returns></returns>
    private IEnumerator PlayAcstion(Vector2 direction)
    {
        // �ړ���Ԃɐݒ�
        _isWalking = true;
        // �J�n���W
        var startPos = transform.localPosition;
        // �I�����W�擾
        var endPos = startPos + (Vector3)direction * _width;
        // ���Ԏw��
        float timer = 0f;
        // timer ��1�ɂȂ�܂ŌJ��Ԃ�
        while(timer < 1)
        {
            timer += Time.deltaTime * _speed;   // ���Ԃ����Z����
            timer = Mathf.Min(timer, 1f);       // �P�𒴂��Ȃ��悤�ɐݒ肷��
            // �����ɉ��������W�ֈړ�������
            transform.localPosition = Vector3.Lerp(startPos, endPos, timer);
            yield return null;                  // �P�t���[���ҋ@����
        }
        _isWalking = false;          �@�@�@�@�@  // �ړ��I��
    }
}

