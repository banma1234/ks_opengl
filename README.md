﻿# 👨‍💻 opengl 오브젝트 pharser

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
      <td/>
  </tr>
  <tr>
    <th>모델 회전</th>
    <th>none.</th>
  </tr>
    </tr>
</table>

<br/>

## 🚀 How to run

이 레포지를 clone하고 루트 폴더의 `main.cpp`를 빌드 및 실행합니다.

필요한 라이브러리들은 직접 설치하시는걸 권장드립니다.

특히 `assimp` 라이브러리는 미리 컴파일된 라이브러리가 아니라 패키지를 `cmake`로 설치하여 빌드한 것이므로 사용자 설정에 차이가 있을 수 있습니다.

자세한건 `Build by`를 참고부탁드립니다.

<br/>

## 📋 Description

- `object` 파일을 opengl에서 읽고 렌더링 및 기타 텍스처 작업을 수행할 수 있도록 하는 `object pharser`입니다.
- 키보드 `W/A/S/D` 버튼으로 카메라를 조작할 수 있습니다.
- 마우스로 카메라 시점을 조작하고 `마우스 휠`로 카메라 줌인/줌아웃이 가능합니다.
- `마우스 좌클릭`을 유지한채 마우스를 왼쪽, 오른쪽으로 이동하면 카메라 시점이 고정된채 3D 모델이 각각 시계, 반시계 방향으로 중심축을 기준으로 `회전`합니다.
- 키보드 `M/G/B` 버튼으로 각각 `metal`, `gold`, `blue` 텍스처를 실시간 적용 가능합니다.

<br/>

## 🛠️ Build by

  ![c++](https://img.shields.io/badge/c++-444444?style=for-the-badge&logo=c)
  ![visual studio](https://img.shields.io/badge/visual_studio-444444?style=for-the-badge&logo=visualstudio)
  ![opengl](https://img.shields.io/badge/opengl-444444?style=for-the-badge&logo=opengl)
  ![github](https://img.shields.io/badge/github-444444?style=for-the-badge&logo=github)

### Library
- opengl
- glfw
- glad
- glm
- assimp