using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<int> GetNumber()
    {
        yield return 10;  // 첫번째 루프에서 리턴되는 값
        yield return 20;  // 두번째 루프에서 리턴되는 값
        yield return 30;  // 세번째 루프에서 리턴되는 값
    }

    static void Main(string[] args)
    {
        foreach (int num in GetNumber())
        {
            Console.WriteLine(num);
        }
    }
}


/* 이러한 특별한 리턴 방식은 다음과 같은 경우에 유용하게 사용된다.
 
(1) 만약 데이타의 양이 커서 모든 데이타를 한꺼번에 리턴하는 것하는 것 보다 조금씩 리턴하는 것이 더 효율적일 경우.
        예를 들어, 어떤 검색에서 1만 개의 자료가 존재하는데, UI에서 10개씩만 On Demand로 표시해 주는게 좋을 수도 있다.
        즉, 사용자가 20개를 원할 지, 1000개를 원할 지 모르기 때문에, 일종의 지연 실행(Lazy Operation)을 수행하는 것이 나을 수 있다.

(2) 어떤 메서드가 무제한의 데이타를 리턴할 경우. 예를 들어, 랜덤 숫자를 무제한 계속 리턴하는 함수는
        결국 전체 리스트를 리턴할 수 없기 때문에 yield 를 사용해서 구현하게 된다.

(3) 모든 데이타를 미리 계산하면 속도가 느려서 그때 그때 On Demand로 처리하는 것이 좋은 경우.
        예를 들어 소수(Prime Number)를 계속 리턴하는 함수의 경우, 소수 전체를 구하면 (물론 무제한의 데이타를 리턴하는 경우이기도 하지만)
        시간상 많은 계산 시간이 소요되므로 다음 소수만 리턴하는 함수를 만들어 소요 시간을 분산하는 지연 계산(Lazy Calculation)을 구현할 수 있다. */