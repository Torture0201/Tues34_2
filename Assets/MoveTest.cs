using DG.Tweening;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //  拡大スケール
    [SerializeField] private float _scale = 1.0f;

    //　拡縮中の場合ture
    private bool _isAction = false;
    //　拡大方向か縮小方向かの判別フラグ
    //　ture: 拡大, false:縮小
    private bool _isBig = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // このスクリプトがはありついているオブジェクトの座標を指定
        transform.position = new Vector3(0.0f, -0.0f, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        //  毎フレーム右に 0.01 m(10cm)移動する
        //transform.position +- new Vector3(
        transform.Rotate(0, 0, -1f);
        if(_isAction is false)
        {
            _isAction = true;
            if (_isBig)
                transform.DOScale(Vector3.one * _scale, 1f)
                    .OnComplete(() => _isAction = false);
            else
                transform.DOScale(Vector3.one, 1f)
                    .OnComplete(() => _isAction = false);
            _isBig = !_isBig;
        }
    }
}
