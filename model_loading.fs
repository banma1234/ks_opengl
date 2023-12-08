#version 330 core
out vec4 FragColor;

in vec2 TexCoords; // ���� ���̴��κ��� ���޹��� �ؽ�ó ��ǥ

uniform sampler2D texture1; // �ؽ�ó ���÷�

void main() {
    FragColor = texture(texture1, TexCoords);
}
