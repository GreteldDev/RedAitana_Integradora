Años atras, solo Dios y yo sabiamos como funcionaba este codigo... Ahora; solo Dios.

# RedAitana_Integradora - Gestión de Visitas

Este proyecto es parte de un sistema de gestión de personal y visitas. Incluye una interfaz en Windows Forms que permite visualizar datos provenientes de múltiples tablas en una base de datos MySQL.

## 📌 Características principales

- Conexión reutilizable a base de datos MySQL mediante una clase dedicada (`ConexionMySQL`).
- Consulta combinada (`UNION`) entre las tablas `personal` y `personalextra`.
- Visualización en `DataGridView` con los datos unificados de ambas tablas.
- Traducción del campo de rol (`IdRol`) al nombre del tipo de rol (`Tipo`) desde la tabla `rol`.

---

## 🧱 Estructura del Proyecto

### 1. `ConexionMySQL.cs`

Contiene la clase que gestiona la conexión a la base de datos MySQL:

```csharp
internal class ConexionMySQL
