# 👨‍💻 opengl 오브젝트 pharser

<br/>

## 🔍 Preview

<table>
  <tr>
    <td>
      <image src="https://github.com/banma1234/ks_opengl/assets/77619465/0a8d1f8a-a2ca-416c-ac69-e76b0853e966"/>
    </td>
        <td>
      <image src="https://github.com/banma1234/ks_opengl/assets/77619465/42cef3c9-89a9-4433-b638-c3d7980c8695"/>
    </td>
  </tr>
  <tr>
    <th>줌 & 줌아웃</th>
    <th>텍스처 변경</th>
  </tr>
    <tr>
    <td>
      <image src="https://github.com/banma1234/ks_opengl/assets/77619465/bd92cc20-64db-4b8c-bd57-bb581ac6efa3"/>
    </td>
    <td>
        none.
    </td>
  </tr>
  <tr>
    <th>모델 회전</th>
    <th> </th>
  </tr>
    </tr>
</table>

<br/>

## 📋 Description

- `object` 파일을 opengl에서 읽고 렌더링 및 기타 텍스처 작업을 수행할 수 있도록 하는 `object pharser`입니다.
- 키보드 `W/A/S/D` 버튼으로 카메라를 조작할 수 있습니다.
- 마우스로 카메라 시점을 조작하고 `마우스 휠`로 카메라 줌인/줌아웃이 가능합니다.
- `마우스 좌클릭`을 유지한채 마우스를 왼쪽, 오른쪽으로 이동하면 카메라 시점이 고정된채 3D 모델이 각각 `시계`, `반시계` 방향으로 중심축을 기준으로 `회전`합니다.
- 키보드 `M/G/B` 버튼으로 각각 `metal`, `gold`, `blue` 텍스처를 실시간 적용 가능합니다.

<br/>

## 🛠️ Used Library

- opengl
- glfw
- glad
- glm
- assimp