using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] Transform[] _groundArr; // Arr -> array
    [SerializeField] float _mapMoveSpeed;
    [SerializeField] float _jumpDistance;
    [SerializeField] float _triggerPosX;

    void Update()
    {
        // 선언식, 조건식, 증감식
        for (int i = 0; i < _groundArr.Length; i++)
        {
            Vector3 curPos = _groundArr[i].position;
            curPos.x -= _mapMoveSpeed * Time.deltaTime;
            if (curPos.x < _triggerPosX) { curPos.x += _jumpDistance; }
            _groundArr[i].position = curPos;
        }
    }
}
