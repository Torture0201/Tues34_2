using UnityEngine;

public class ButtonView : MonoBehaviour
{
    /// <summary>
    /// 外部からアクセスできるようにpublicの関数にする
    /// ボタンを押したらそこから呼び出せるようにする
    /// </summary>
    public void ButtonTap()
    {
        //　デバッグウィンドウに情報を表示する
        Debug.Log("Click");
    }
}
