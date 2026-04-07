# 📝 Todo API - .NET

API REST para gestión de tareas desarrollada con ASP.NET Core.

---

## 🚀 Descripción

Este proyecto consiste en una API que permite gestionar tareas mediante operaciones CRUD (crear, leer, actualizar y eliminar).

Fue desarrollado aplicando buenas prácticas de desarrollo backend, incluyendo separación de capas, uso de DTOs y persistencia de datos.

---

## 🧱 Arquitectura

El proyecto sigue una estructura en capas:

- **Controllers** → Manejo de endpoints HTTP
- **Services** → Lógica de negocio
- **DTOs** → Transferencia de datos
- **Data (DbContext)** → Acceso a base de datos
- **Models** → Entidades

---

## ⚙️ Tecnologías utilizadas

- .NET / C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Git / GitHub
- Docker (básico)

---

## 📌 Funcionalidades

- Crear tareas
- Obtener lista de tareas
- Actualizar tareas
- Eliminar tareas
- Validación básica de datos

---

## ▶️ Cómo ejecutar el proyecto

1. Clonar el repositorio:

```bash
git clone https://github.com/TU-USUARIO/TU-REPO.git
cd TU-REPO
```

2. Restaurar dependencias:

```bash
dotnet restore
```

3. Ejecutar migraciones:

```bash
dotnet ef database update
```

4. Ejecutar la aplicación:

```bash
dotnet run
```

---

## 🌐 Acceso a la API

Una vez ejecutado, acceder a:

```
https://localhost:xxxx/swagger
```

Desde Swagger se pueden probar todos los endpoints.

---

## 🐳 Docker

Construir imagen:

```bash
docker build -t todo-api .
```

Ejecutar contenedor:

```bash
docker run -p 5000:80 todo-api
```

---

## 📚 Aprendizajes

Durante este proyecto se trabajó en:

Desarrollo de APIs REST con ASP.NET Core
Uso de Entity Framework Core con SQLite
Implementación de arquitectura en capas
Manejo de DTOs y validaciones
Uso de Git para control de versiones
Introducción a Docker

---
