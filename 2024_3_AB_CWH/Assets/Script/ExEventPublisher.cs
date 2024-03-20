using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEventPublisher : MonoBehaviour
{
    public ExEventChannel eventChannel;

    private void Update()
    {
        //스페이스바를 누를때
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventChannel.RaiseEvent();  //스트립터블 이벤트 호출
        }
    }
}
