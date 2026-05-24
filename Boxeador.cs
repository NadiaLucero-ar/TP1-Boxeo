using System;

namespace BOXEO
{
    public enum PosturaDefensiva
    {
       CubrirRostro,
       CubrirMenton,
       CubrirCostado
        
    }

    public class Boxeador
    {
        public string Nombre { get; set; }
        public int NivelFuerza { get; set; }
        public PosturaDefensiva Postura { get; set; }

        public Boxeador(string nombre, int nivelFuerza) 
        {
            Nombre = nombre;
            NivelFuerza = nivelFuerza;
        }
//METODOS: ATAQUE - RECIBE EL OPONENTE 

//Descuenta 2 puntos si el oponente se cubre con CubrirMenton o CubrirCostado
        public void Jab(Boxeador oponente)
        {
            if (oponente.Postura == PosturaDefensiva.CubrirMenton || oponente.Postura == PosturaDefensiva.CubrirCostado)
            
            {
                oponente.DisminuirFuerza(2); 
            }
        }

//Descuenta 4 puntos si el oponente se cubre con CubrirRostro o CubrirCostado
        public void Uppercut(Boxeador oponente)
        {
                if (oponente.Postura == PosturaDefensiva.CubrirRostro || oponente.Postura == PosturaDefensiva.CubrirCostado)
            
            {
                oponente.DisminuirFuerza(4); 
            }
        }

//Descuenta 1 punto si el oponente se cubre con CubrirMenton o CubrirRostro
        public void Gancho(Boxeador oponente )
        {
                if (oponente.Postura == PosturaDefensiva.CubrirMenton || oponente.Postura == PosturaDefensiva.CubrirRostro)
            
            {
                oponente.DisminuirFuerza(1); 
            }
        }
    
    //METODOS: DEFENSA 
        public void CubrirRostro()   
        { Postura = PosturaDefensiva.CubrirRostro; }
        public void CubrirMenton()   
        { Postura = PosturaDefensiva.CubrirMenton; }
        public void CubrirCostado()   
        { Postura = PosturaDefensiva.CubrirCostado; }
    
    //METODO: CALCULAR DAÑO RECIBIDO 
        public void DisminuirFuerza(int nivel)
        {
            NivelFuerza = NivelFuerza - nivel; //Resta el daño recibido
            if (NivelFuerza <= 0)
            {
               NivelFuerza = 0; // Evita que la fuerza sea negativa
            }
            Knockout();
        }
        public void Knockout()
        {
            if (NivelFuerza == 0)
            {
                Console.WriteLine($"El boxeador {Nombre} está knockout !");
            }
        }

    }
}