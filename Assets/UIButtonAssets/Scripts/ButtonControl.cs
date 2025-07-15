using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    // ボタンの番号用テキスト
    [SerializeField] private TextMeshProUGUI _indexText;
    // ボタンの iindex
    private int _index;

    /// <summary>
    /// ボタンの index　を設定する関数
    /// </summary>
    /// <param name="index">設定する index</param>
    public void IndexSetup(int index)
    {
        _index = index;
        DispIndex();
    }
    
    /// <summary>
    /// テキストに index を表示
    /// </summary>
    private void DispIndex()
    {
        // 数字を文字に変換してテキストに表示
        _indexText.text = _index.ToString();
    }
    /// <summary>
    /// ボタンを押したときに呼び出されるオリジナル関数
    /// </summary>
    public void OnClickButton()
    {
        // 新しく自分のクローン（コピー）を生成する
        // 自分がぶら下がっている親分の手下にする
        var buttonItem = Instantiate(gameObject, transform.parent);
        // ヒエラルキーのボタン表示名を Button に変更
        buttonItem.name = "Button";
        // inddex を１加算して新しボタンに渡す
        buttonItem.GetComponent<ButtonControl>().IndexSetup(_index + 1);
        // 表示場所をランダムに設定する
        buttonItem.transform.localPosition = new Vector3(Random.Range(-920, 920), 
                                                         Random.Range(-500, 500), 
                                                         0);
        // 自分を削除する
        Destroy(gameObject);
    }
}
