#version 330 core
out vec4 FragColor;

in vec2 TexCoords; // 정점 쉐이더로부터 전달받은 텍스처 좌표

uniform sampler2D texture1; // 텍스처 샘플러

void main() {
    FragColor = texture(texture1, TexCoords);
}
