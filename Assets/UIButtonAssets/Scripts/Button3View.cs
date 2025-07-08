using UnityEngine;

public class Button3View : MonoBehaviour
{
    // 移動対象の Transform をアタッチ
    [SerializeField] private Transform _targetpos;
    
    /// <summary>
    /// 移動対象を指定の座標に移動
    /// </summary>
    public void MoveTarget()
    {
        // (x,y,z) の座標で移動先を指定する
        // 20の場合、z は0にしておくといい
        _targetpos.localPosition = new Vector3(5f, 3f, 0);
    }
}
