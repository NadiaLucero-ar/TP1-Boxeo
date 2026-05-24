# 🥊 TP1 - Ejercicio Boxeo

## Consigna
Crear una clase Boxeador con propiedades y métodos que simulen un combate de boxeo.

## Propiedades
- **Nombre** (string): Nombre del boxeador
- **NivelFuerza** (int): Nivel de fuerza del boxeador, rango 0 a 10
- **Postura** (enum): Tipo de defensa empleada

## Postura Defensiva (Enum)
- `CubrirRostro`
- `CubrirMenton`
- `CubrirCostado`

## Métodos de Ataque
| Método | Descuenta si el oponente tiene | Puntos |
|--------|-------------------------------|--------|
| `Jab()` | CubrirMenton o CubrirCostado | -2 |
| `Uppercut()` | CubrirRostro o CubrirCostado | -4 |
| `Gancho()` | CubrirMenton o CubrirRostro | -1 |

## Métodos de Defensa
- `CubrirRostro()`: Almacena CubrirRostro en la propiedad Postura
- `CubrirMenton()`: Almacena CubrirMenton en la propiedad Postura
- `CubrirCostado()`: Almacena CubrirCostado en la propiedad Postura

## Otros Métodos
- `DisminuirFuerza(int nivel)`: Resta puntos al NivelFuerza
- `Knockout()`: Muestra un mensaje cuando NivelFuerza llega a 0

## Tecnologías
- C#
- .NET