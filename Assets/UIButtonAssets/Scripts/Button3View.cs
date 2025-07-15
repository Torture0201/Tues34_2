using UnityEngine;

public class Button3View : MonoBehaviour
{
    // �ړ��Ώۂ� Transform ���A�^�b�`
    [SerializeField] private Transform _targetPos;
    // �F�ւ������� spriteRenderer ���A�^�b�`
    [SerializeField] private SpriteRenderer _targetSprite;
    // �F��I���ł���悤�ɔz��f�[�^���쐬
    private Color[] _colors = 
    {
        Color.yellow, 
        Color.blue,
        Color.green,
        Color.red,
        new Color(0.1f, 1.0f, 0.8f, 0.1f)
    };
    // �I�𒆂̐F�̔z��ԍ�
    private int _colorIndex = 0;
    
    /// <summary>
    /// �ړ��Ώۂ��w��̍��W�Ɉړ�
    /// </summary>
    public void MoveTarget()
    {
        // (x,y,z) �̍��W�ňړ�����w�肷��
        // 20�̏ꍇ�Az ��0�ɂ��Ă����Ƃ���
        _targetPos.localPosition = new Vector3(5f, 3f, 0);
    }
    /// 
    /// �Ώۂ̐F���N���b�N���邲�Ƃɕω�������
    /// 
    public void ChangeColor()
    {
        // index ���w�������F���X�v���C�g�ɐݒ肷��
        _targetSprite.color = _colors[_colorIndex];
        // index ��1���Z����
        _colorIndex++;
        // index ���o�^���Ă���@_colors �̌��𒴂��Ȃ��悤�ɒ�������
        _colorIndex %= _colors.Length;
    }
    

}
