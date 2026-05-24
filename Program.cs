using System;
using BOXEO;

        
            Boxeador boxeador1 = new Boxeador("Mike", 10);
            Boxeador boxeador2 = new Boxeador("Rocky", 10);

            // ROUND 1
            boxeador2.CubrirMenton();
            boxeador1.Jab(boxeador2);
            Console.WriteLine($"Rocky: {boxeador2.NivelFuerza}");

            // --- ROUND 2 ---
            boxeador1.CubrirRostro();          // Mike se cubre el rostro
            boxeador2.Uppercut(boxeador1);     // Uppercut SÍ descuenta vs CubrirRostro → -4
            Console.WriteLine($"Mike: {boxeador1.NivelFuerza}");   // esperado: 6

            // --- ROUND 3 ---
            boxeador2.CubrirCostado();         // Rocky cambia defensa
            boxeador1.Gancho(boxeador2);       // Gancho NO descuenta vs CubrirCostado → sin cambio
            Console.WriteLine($"Rocky: {boxeador2.NivelFuerza}");  // esperado: 8 (igual)

            // Llevar a Rocky al KO
            boxeador2.CubrirCostado();
            boxeador1.Uppercut(boxeador2); // -4 → Rocky: 4
            boxeador1.Uppercut(boxeador2); // -4 → Rocky: 0 → KO!
        
    