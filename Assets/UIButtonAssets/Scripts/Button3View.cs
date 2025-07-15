using UnityEngine;

public class Button3View : MonoBehaviour
{
    // 移動対象の Transform をアタッチ
    [SerializeField] private Transform _targetPos;
    // 色替えをする spriteRenderer をアタッチ
    [SerializeField] private SpriteRenderer _targetSprite;
    // 色を選択できるように配列データを作成
    private Color[] _colors = 
    {
        Color.yellow, 
        Color.blue,
        Color.green,
        Color.red,
        new Color(0.1f, 1.0f, 0.8f, 0.1f)
    };
    // 選択中の色の配列番号
    private int _colorIndex = 0;
    
    /// <summary>
    /// 移動対象を指定の座標に移動
    /// </summary>
    public void MoveTarget()
    {
        // (x,y,z) の座標で移動先を指定する
        // 20の場合、z は0にしておくといい
        _targetPos.localPosition = new Vector3(5f, 3f, 0);
    }
    /// 
    /// 対象の色をクリックするごとに変化させる
    /// 
    public void ChangeColor()
    {
        // index が指し示す色をスプライトに設定する
        _targetSprite.color = _colors[_colorIndex];
        // index を1加算する
        _colorIndex++;
        // index が登録してある　_colors の個数を超えないように調整する
        _colorIndex %= _colors.Length;
    }
    

}
