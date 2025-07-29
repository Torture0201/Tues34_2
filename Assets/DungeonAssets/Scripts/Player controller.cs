using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private GamePlayerInput _playerInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput = new GamePlayerInput();
        _playerInput.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = _playerInput.Player.Move.ReadValue<Vector2>();
        transform.localPosition += (Vector3)direction * 0.01f;
    }
}
