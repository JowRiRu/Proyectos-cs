using System;

class persona{
    public persona(string nombre, int edad, string dni);

    private string nombre;
    public string Nombre{
        get { return nombre}
        set {nombre = value}
    }
    
    private int edad;
    public int Edad{
        get {return edad}
        set {nombre = value}
    }
    
    private string dni;
    public string Dni {
        get{return dni}
        set {dni = value}
    }

    public void mostrar(){
        Console.WiteLine("La persona se llama: " + nombre + "tambien tiene "+ edad + "años, aparte su dni es: "+ dni);
    }

    public void mayorDeEdad(){
        if(persona.edad >= 18){
            console.WriteLine("Es Mayor de edad");
        } 
        else {
            console.WriteLine("No es mayor de edad");
        }
    }
}

class Programa{
    static void Main(string[] args){
        persona personaEjemplo = new persona();
        personaEjemplo.Nombre = "Javier";
        personaEjemplo.Edad = 12;
        personaEjemplo.Dni = "12345678A";
        console.WriteLine(personaEjemplo.Nombre);   
    }
}

class Cuenta{

    public Cuenta(string titular, int cantidad);

    private string titular;
    public string Titular{
        get {return titular}
        set {titular = value}
    }

    private int cantidad;
    public int Cantidad{
        get {return cantidad}
        set {cantidad = value}
    }

    public void mostrar(){
        Console.WriteLine("El titular es: " + titular)
    }
}