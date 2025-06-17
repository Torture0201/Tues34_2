using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class MoveTest2 : MonoBehaviour
{
    // SerializeField はインスペクター（情報窓）に指定した変数などを
    //　表示して外部から入れ替えできるようにする命令
    [SerializeField] private float _rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 外部で設定したスピードで回転させる
        transform.Rotate(0f,0f,_rotateSpeed);
    }
}
