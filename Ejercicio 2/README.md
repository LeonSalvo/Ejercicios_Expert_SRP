# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**


1) 
Para poder agregar cualquier tipo de dato a los pacientes o a los doctores, es necesario separarlos en diferentes clases.
Los atributos no tienen getters y setters.

2)
[
  {
    "name": "Paciente",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Almacenar datos del paciente",
      "Validar los datos"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "Doctor ",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Almacenar los datos del doctor ",
      "Validar los datos"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "ApointmentService",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Imprime si se pudo armar la consulta y si faltan alguno de los datos "
    ],
    "collaborators": [
      "Doctor",
      "Paciente"
    ]
  },
  {
    "name": "Consulta",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Almacenar todos los datos de la consulta (incluyendo el nuevo identificador)"
    ],
    "collaborators": [
      "Doctor ",
      "Paciente ",
      "ApointmentService"
    ]
  }
]