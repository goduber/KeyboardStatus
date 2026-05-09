Keyboard & Battery Status System ⌨️🔋

Una utilidad ligera para Windows diseñada para mejorar la experiencia del usuario en dispositivos que carecen de indicadores físicos de estado. Este sistema notifica en tiempo real 
el estado de la tecla Caps Lock y gestiona alertas inteligentes para el mantenimiento de la batería.

🚀 Características principales

  ⚪ Indicador Visual de Caps Lock: El icono de la bandeja de sistema cambia dinámicamente para reflejar si las mayúsculas están activas.

  ⚪ Gestión Inteligente de Batería:

  Notificación visual al llegar al 100% de carga para optimizar la vida útil del equipo.

  Alerta crítica al bajar del 10% para prevenir la pérdida de datos por apagado.

  ⚪ Menú Contextual Informativo: Acceso rápido con un clic derecho para visualizar:

  Nivel exacto de batería y estado de carga.

  Estado de Num Lock y Scroll Lock.

  ⚪ Optimización de Recursos: Implementación de una estrategia de caché de iconos y gestión de memoria nativa para asegurar un consumo de RAM mínimo y constante.

🛠️ Desafíos Técnicos y Soluciones

Como Systems Analyst, el enfoque principal fue la eficiencia del sistema:

  Gestión de Memoria GDI+:
    Durante el desarrollo, se identificó un consumo progresivo de memoria (Memory Leak) al convertir imágenes PNG a iconos en tiempo real. La solución consistió en implementar un patrón de 
    Caché de Recursos y el uso correcto de la interfaz IDisposable, logrando que la aplicación mantenga un perfil de consumo plano durante horas de ejecución.

💻 Tecnologías utilizadas

  ▶️ Lenguaje: C# (.NET 10)
  ▶️ Interoperabilidad (P/Invoke): Uso de user32.dll para la gestión de recursos nativos de Windows.
  ▶️Entorno: Visual Studio 2022.
