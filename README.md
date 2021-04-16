# Cost of 10k Update() calls

### 개요

Unity Message중 하나인 Update의 호출시 비용을 테스트하기 위한 유니티 프로젝트입니다.
n개의 작업을 위해 n개의 Update를 호출할 때의 프레임 시간과 1개의 Update를 호출할 때의 프레임 시간을 비교함으로, Update를 호출할 때의 비용을 확인합니다.
그 외 자세한 내용은 [블로그 포스트]()를 참조해주시기 바랍니다.

### 실행 방법

1. Project 윈도우에서 "01.Scenes"에서 'Test Scene'을 연다.
2. Hierarchy 윈도우에서 Behaviours라는 이름을 가진 오브젝트를 선택한다. 
3. Inspector 윈도우에서 Behaviour Cloner라는 Component를 찾는다.
4. Length에 생성하고자 하는 Object의 수를 입력한다. 예) 10000
5. Behaviour Component에는 Project 윈도우의 "03.Prefabs" 폴더 아래에 있는 Prefab 중 하나를 넣는다. 각각은 아래와 같다.
   1. Coroutine Update Behaviour : Coroutine을 이용한 Update 방식
   2. Custom Update Behaviour : Update Manager를 이용한 Update 방식
   3. Update Behaviour : 일반적인 Update Unity Message를 이용한 방식
6. Play를 하고, Log를 확인한다.

### 테스트 결과

| 1. 일반적인 Update 방식 | 2. Coroutine을 이용한 방식 | 3. Update Manager를 이용한 방식 |
| :---------------------: | :-----------------------: | :----------------------------: |
|         2.46ms          |          0.15ms           |             0.10ms             |

### 테스트환경
- OS : 윈도우10
- 유니티 버전 : 2020.3.3f1
- 스크립팅 백엔드 : IL2CPP
- 빌드가 아닌 에디터 환경에서 실시
