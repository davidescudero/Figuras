namespace Figura;

abstract class Rectangulo:IFigura{
    public int alto{get; set;}
    public int ancho{get; set;}

    public int area()
    {
        return alto*ancho;
    }
}