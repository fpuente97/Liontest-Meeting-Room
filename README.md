# Liontest Meeting Room
## Evaluación de Sistema CRUD
### [Por Fernando Puente](https://github.com/fpuente97)

Aplicación para reservar salas de juntas mediante un sistema CRUD utilizando `C#` y `MariaDB SQL`

Objetivos del Software:

* Reservar una sala de juntas con un rango de horario inicial y final.
* No permitir reservar sala de juntas que esté ocupada en el horario indicado.
* No permitir reservar sala de juntas por más de 2 hora.
* Liberar la sala de juntas al vencer horario de reserva.
* Liberar la sala de juntas de manera manual.

### Observaciones
* Utilización de un evento programado para ejecutar un procedimiento que actualiza el valor de reserva activa a falso.
* Se utiliza una base de datos con conexión directa mediante URL (para fines de prueba). Esta será eliminada.
