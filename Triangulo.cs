namespace Figura;

class Triangulo:IFigura{

    public Triangulo(int alto, int baseT){
        this.alto = alto;
        this.ancho = baseT;
    }
    public int alto{get;set;}
    public int ancho{get;set;}

    public int area(){
        return (this.ancho*this.alto)/2;
    }
}