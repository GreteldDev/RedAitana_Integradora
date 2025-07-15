📝 Software de Registro de Entradas y Salidas
📋 Descripción

Este software está diseñado para la gestión y registro de entradas y salidas de colaboradores (trabajadores) y visitantes (beneficiarios) en una organización. Permite controlar quién entra y sale, registrar visitas manualmente o por selección, y visualizar el historial de registros.
⭐ Funcionalidades Principales

    👷‍♂️ Registro y gestión de colaboradores y visitantes.

    🕒 Registro automático de entrada y salida con fecha y hora.

    🏷️ Dos modalidades para registrar visitas:

        Visita General: Registro manual de entrada y salida.

        Visita por Selección: Selección directa del colaborador o visitante desde una lista filtrable.

    📊 Visualización general de todos los registros con información detallada.

    ✏️ Edición de registros existentes.

🚀 Cómo utilizar el software
🏠 Inicio y Visualización General

    Al abrir el software, verás la ventana principal Registro General con la tabla de registros de entradas y salidas.

    La tabla muestra:

        👤 Nombre y Apellido

        🎭 Rol (colaborador o visitante)

        ⏰ Fecha y hora de entrada y salida

🔑 Registro de Entrada y Salida

    🔍 Registro por Selección:

        Haz clic en el botón Visita por Selección.

        Se abrirá una ventana con la lista de colaboradores y visitantes.

        Usa la barra de búsqueda para filtrar por nombre o apellido.

        Selecciona la persona deseada.

        Pulsa Registrar Entrada o Registrar Salida para guardar el evento.

    ✍️ Registro Manual (Visita General):

        Haz clic en el botón Visita General.

        Ingresa manualmente los datos de la visita.

        Registra la entrada o salida correspondiente.

👥 Registro de Colaboradores y Visitantes

    El software tiene bases de datos separadas para:

        👷‍♀️ Colaboradores/Trabajadores

        🧑‍🤝‍🧑 Visitantes/Beneficiarios

    Ambos grupos aparecen en la lista para selección y registro.

    Incluye nombres, apellidos y rol asignado.

✏️ Edición de Registros

    Haz clic en el botón Editar para abrir la ventana de edición.

    Modifica información de registros existentes (fechas, roles, etc).

🛠️ Requisitos Técnicos

    🐬 MySQL para la base de datos.

    💻 .NET Framework para la aplicación Windows Forms.

    🔧 Configurar correctamente la conexión en la clase ConexionMySQL.

📂 Estructura del Código

    RegistroGeneral.cs: Formulario principal con historial y acceso a otras ventanas.

    VisitaPorSeleccion.cs: Registro de visitas con lista filtrable.

    VisitaGeneral.cs: Registro manual de visitas.

    EditarGeneral.cs: Edición de registros.

    ConexionMySQL.cs: Manejo de la conexión a MySQL.
