using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIAddSubTest : MonoBehaviour
{
    // 追加するIconプレハブのベース
    [SerializeField] private GameObject _iconPrefab;
    // Iconお追加する場所
    [SerializeField] private Transform _iconParent;

    private InputSystem_Actions _inputActions;
    private int _prefabCount = 1;　　　　　　　　　　　　　　　　　//　登録したプレハブの総数
    private List<GameObject> _icons = new List<GameObject>();　　//　追加生成したオブジェクト総数

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //　input system 初期化
        _inputActions = new InputSystem_Actions();
        _inputActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputActions.UI.Click.triggered)
        {
            if (_prefabCount == 4) return;
            _prefabCount++;
            var icon = Instantiate(_iconPrefab, _iconParent);
            _icons.Add(icon);
            Debug.Log("マウス左クリック");
        }
        //　マウス左クリック
        else if(_inputActions.UI.RightClick.triggered)
        {
            if (_prefabCount == 1) return;
            _prefabCount--;
            var icon = _icons[^1];
            _icons.Remove(icon);
            Destroy(icon);
            Debug.Log("マウス右クリック");
        }
    }
}
