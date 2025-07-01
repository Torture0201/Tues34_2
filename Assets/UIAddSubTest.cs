using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIAddSubTest : MonoBehaviour
{
    // �ǉ�����Icon�v���n�u�̃x�[�X
    [SerializeField] private GameObject _iconPrefab;
    // Icon���ǉ�����ꏊ
    [SerializeField] private Transform _iconParent;

    private InputSystem_Actions _inputActions;
    private int _prefabCount = 1;�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@//�@�o�^�����v���n�u�̑���
    private List<GameObject> _icons = new List<GameObject>();�@�@//�@�ǉ����������I�u�W�F�N�g����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�@input system ������
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
            Debug.Log("�}�E�X���N���b�N");
        }
        //�@�}�E�X���N���b�N
        else if(_inputActions.UI.RightClick.triggered)
        {
            if (_prefabCount == 1) return;
            _prefabCount--;
            var icon = _icons[^1];
            _icons.Remove(icon);
            Destroy(icon);
            Debug.Log("�}�E�X�E�N���b�N");
        }
    }
}
