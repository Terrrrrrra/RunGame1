using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rd;
    [SerializeField] Animator _animator;
    PlayerInput _playerInput; // 신규인풋시스템을 전역변수로 선언

    [SerializeField] float _jumpPower;
    bool _jumpable;

    void Start()
    {
        _playerInput = new PlayerInput(); // 인풋시스템 생성
        _playerInput.Enable(); // 인풋시스템 활성화
        _jumpable = true;
    }

    void Update()
    {
        if (_playerInput.Player.Jump.WasPerformedThisFrame())
        {
            if (_jumpable)
            {
                _jumpable = false;
                _rd.AddForce(new Vector2(0, _jumpPower), ForceMode2D.Impulse);
                _animator.SetTrigger("Jump");
                _animator.SetBool("IsGround", false);
                print("점프");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _animator.SetBool("IsGround", true);
            _jumpable = true;
            print("점프종료");
        }
    }
}
