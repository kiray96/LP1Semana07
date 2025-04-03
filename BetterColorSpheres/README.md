```Mermaid 
    classDiagram
    Color <-- Sphere : use
    class Color{
      +Red: byte
      +Blue: byte
      +Green: byte
      +Alpha: byte
      +Grey()
    }
    class Sphere{
      +Raio: int
      +Contagem: int
      +Cor: Color
      +Pop()
      +Throw()
    }
```
