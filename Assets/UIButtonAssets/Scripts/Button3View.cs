using UnityEngine;

public class Button3View : MonoBehaviour
{
    // �ړ��Ώۂ� Transform ���A�^�b�`
    [SerializeField] private Transform _targetpos;
    
    /// <summary>
    /// �ړ��Ώۂ��w��̍��W�Ɉړ�
    /// </summary>
    public void MoveTarget()
    {
        // (x,y,z) �̍��W�ňړ�����w�肷��
        // 20�̏ꍇ�Az ��0�ɂ��Ă����Ƃ���
        _targetpos.localPosition = new Vector3(5f, 3f, 0);
    }
}
