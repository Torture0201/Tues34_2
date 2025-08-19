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
    [SerializeField, Header("速度")] private float _speed = 1f;
    [SerializeField, Header("移動幅")] private float _width = 0.5f;

    private Animator _animator; 
    private GamePlayerInput _playerInput;
    // プレイヤーステータス
    private PlayerStatus _playerStatus = PlayerStatus.frontIdle;
    // 移動中フラグ
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
        // 右移動の場合
        if (direction.x > 0)
        {
            if(_playerStatus != PlayerStatus.rightWalk)
            {
                _playerStatus = PlayerStatus.rightWalk;
                _animator.SetTrigger(PlayerStatus.rightWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.right));
        }
        // 左移動の場合
        else if (direction.x < 0)
        {
            if (_playerStatus != PlayerStatus.leftWalk)
            {
                _playerStatus = PlayerStatus.leftWalk;
                _animator.SetTrigger(PlayerStatus.leftWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.left));
        }
        // 上移動の場合
        else if (direction.y > 0)
        {
            if (_playerStatus != PlayerStatus.backWalk)
            {
                _playerStatus = PlayerStatus.backWalk;
                _animator.SetTrigger(PlayerStatus.backWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.up));
        }
        // 下移動の場合
        else if (direction.y < 0)
        {
            if (_playerStatus != PlayerStatus.frontWalk)
            {
                _playerStatus = PlayerStatus.frontWalk;
                _animator.SetTrigger(PlayerStatus.frontWalk.ToString());
            }
            StartCoroutine(PlayAcstion(Vector2.down));
        }
        // 移動しない場合
        else StopStatusCheck();
    }

    private void StopStatusCheck()
     {
        // 直前が前移動ならば、前停止アニメーションに変更
        if(_playerStatus == PlayerStatus.frontWalk)
        {
            _playerStatus = PlayerStatus.frontIdle;
            _animator.SetTrigger(PlayerStatus.frontIdle.ToString());
        }
        // 直前が後ろ移動ならば、後ろ停止アニメーションに変更
        if (_playerStatus == PlayerStatus.backWalk)
        {
            _playerStatus = PlayerStatus.backIdle;
            _animator.SetTrigger(PlayerStatus.backIdle.ToString());
        }
        // 直前が左移動ならば、左停止アニメーションに変更
        if (_playerStatus == PlayerStatus.leftWalk)
        {
            _playerStatus = PlayerStatus.leftIdle;
            _animator.SetTrigger(PlayerStatus.leftIdle.ToString());
        }
        // 直前が右移動ならば、右停止アニメーションに変更
        if (_playerStatus == PlayerStatus.rightWalk)
        {
            _playerStatus = PlayerStatus.rightIdle;
            _animator.SetTrigger(PlayerStatus.rightIdle.ToString());
        }
    }


    /// <summary>
    /// キャラクターの移動
    /// </summary>
    /// <param name="direction">移動方向</param>
    /// <returns></returns>
    private IEnumerator PlayAcstion(Vector2 direction)
    {
        // 移動状態に設定
        _isWalking = true;
        // 開始座標
        var startPos = transform.localPosition;
        // 終了座標取得
        var endPos = startPos + (Vector3)direction * _width;
        // 時間指定
        float timer = 0f;
        // timer が1になるまで繰り返し
        while(timer < 1)
        {
            timer += Time.deltaTime * _speed;   // 時間を加算する
            timer = Mathf.Min(timer, 1f);       // １を超えないように設定する
            // 割合に応じた座標へ移動させる
            transform.localPosition = Vector3.Lerp(startPos, endPos, timer);
            yield return null;                  // １フレーム待機する
        }
        _isWalking = false;          　　　　　  // 移動終了
    }
}

