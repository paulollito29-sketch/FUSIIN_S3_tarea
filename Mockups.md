# Mockups funcionales - SportMaster Pro

Este documento contiene los mockups de interfaz para los prompts solicitados.

---

## Prompt 1: Dashboard Principal y Gestión de Torneos (RF01, RF09)

```text
+----------------------------------------------------------------------------------+
| SportMaster Pro - Dashboard Principal                                            |
+----------------------------------------------------------------------------------+
| [Torneo Activo v] [Deporte v] [Temporada v]                  [Nuevo Torneo]     |
|----------------------------------------------------------------------------------|
| KPIs                                                                             |
| [Torneos Activos: 04] [Equipos: 32] [Partidos Jugados: 58] [Pendientes: 06]     |
|----------------------------------------------------------------------------------|
| Gestión de Torneos (RF01)                                                        |
| Código: [________]  Nombre: [____________________]  Deporte: [____v]            |
| Fecha inicio: [dd/mm/aaaa]  Estado: [Activo v]            [Guardar] [Editar]    |
|                                                              [Dar de baja]       |
|----------------------------------------------------------------------------------|
| Tabla de torneos                                                                  |
| Código | Torneo | Deporte | Fecha inicio | Estado | Equipos | Acciones          |
|----------------------------------------------------------------------------------|
| Rendimiento top 5 equipos (RF09)                                                 |
| [Gráfico barras: Puntos obtenidos vs Puntos posibles]                            |
+----------------------------------------------------------------------------------+
```

---

## Prompt 2: Registro de Equipos y Jugadores (RF02, RF03, RNF06)

```text
+----------------------------------------------------------------------------------+
| Registro de Equipos y Jugadores                                                  |
+----------------------------------------------------------------------------------+
| Seleccionar torneo: [Copa Apertura 2026 v]                                       |
|----------------------------------------------------------------------------------|
| Registro de equipo (RF02)                                                         |
| Nombre equipo: [___________________]  DNI delegado: [________] [Registrar]      |
| Contacto delegado: [_________________________]                                   |
|----------------------------------------------------------------------------------|
| Equipos inscritos                                                                  |
| Equipo | Delegado | DNI | Jugadores | Estado | Acciones                          |
|----------------------------------------------------------------------------------|
| Registro de jugadores por equipo (RF03)                                           |
| Equipo: [Leones FC v]                                                             |
| Nombre: [________________] DNI: [________] Edad: [__] [Agregar jugador]         |
|----------------------------------------------------------------------------------|
| Lista de jugadores                                                                 |
| # | Nombre completo | DNI | Edad | Posición | Acciones                           |
|----------------------------------------------------------------------------------|
| RNF06 - Usabilidad                                                                 |
| (✓) Mensajes claros   (✓) Validación en tiempo real   (✓) Flujo en 2 pasos       |
+----------------------------------------------------------------------------------+
```

---

## Prompt 3: Generación de Fixture y Resultados (RF04, RF05, RF10)

```text
+----------------------------------------------------------------------------------+
| Fixture y Resultados                                                              |
+----------------------------------------------------------------------------------+
| Torneo: [Copa Apertura 2026 v]                                                    |
| Modo de fixture: ( ) Aleatorio  ( ) Por grupos  Grupos: [4]                      |
| [Generar fixture] [Regenerar]                                                     |
|----------------------------------------------------------------------------------|
| Fixture generado (RF04)                                                           |
| Fecha | Grupo | Local | Visitante | Estado | Cancha | Hora                        |
|----------------------------------------------------------------------------------|
| Registro de resultados (RF05)                                                      |
| Partido: [Leones FC vs Tigres FC v]                                               |
| Marcador Local: [__]  Marcador Visitante: [__]  [Guardar resultado]              |
|----------------------------------------------------------------------------------|
| Auditoría de cambios (RF10)                                                        |
| Usuario | Fecha/Hora | Acción | Valor anterior | Valor nuevo                      |
|----------------------------------------------------------------------------------|
| [Exportar auditoría]                                                              |
+----------------------------------------------------------------------------------+
```

---

## Prompt 4: Reporte - Tabla de Posiciones (RF06, RNF07)

```text
+----------------------------------------------------------------------------------+
| Reportes > Tabla de Posiciones                                                    |
+----------------------------------------------------------------------------------+
| Torneo: [Copa Apertura 2026 v]   Fecha corte: [dd/mm/aaaa]   [Actualizar]        |
|----------------------------------------------------------------------------------|
| Tabla de posiciones (RF06)                                                        |
| Pos | Equipo     | PJ | PG | PE | PP | GF | GC | DG | Puntos | Forma             |
|----------------------------------------------------------------------------------|
| 1   | Leones FC  | 10 |  7 |  2 |  1 | 18 |  7 |+11 |   23   | G-G-E-G-G         |
| 2   | Tigres FC  | 10 |  6 |  3 |  1 | 16 |  8 | +8 |   21   | G-E-G-P-G         |
| ...                                                                              |
|----------------------------------------------------------------------------------|
| RNF07 - Rendimiento y tiempos de respuesta                                        |
| Última actualización: 03/05/2026  Tiempo de cálculo: 120ms  Estado: Óptimo       |
|----------------------------------------------------------------------------------|
| [Descargar PDF] [Exportar Excel] [Compartir]                                     |
+----------------------------------------------------------------------------------+
```

---

## Cobertura de requerimientos

- **RF01**: Crear/editar/dar de baja torneos en Dashboard.
- **RF02**: Inscripción de equipos por torneo y delegado.
- **RF03**: Registro de jugadores por equipo con datos obligatorios.
- **RF04**: Generación automática de fixture por modo aleatorio o grupos.
- **RF05**: Carga de resultados y persistencia inmediata.
- **RF06**: Tabla automática de posiciones con PJ, PG, PE, PP y puntos.
- **RF09**: Gráfico comparativo de top 5 equipos.
- **RF10**: Trazabilidad de cambios de resultados.
- **RNF06/RNF07**: Lineamientos de usabilidad y desempeño visibles en cada vista.
