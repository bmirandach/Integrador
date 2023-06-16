¿Qué es el IL?

El IL es el intermediate language. En .NET framework el código escrito en C# no se ejecuta directamente. Primero el compilador (roslyn) convierte el código C# a este IL, este codigo luego en tiempo de ejecución se compila a código nativo(bytecode) que lo puede ejecutar el CPU. Es el CLR el que lo compila a bytecode.


Explique con sus palabras VES, CTS y CLS

Son parte de las reglas que permiten tener la arquitectura base para la plataforma .NET. El VES, Virtual Execution System, brinda la capa de abstracción entre el hardware y el IL, ejecuta este código IL de una forma segura El CTS, Common Type System, brinda el conjunto general de tipos de datos y las convenciones que tienen que tener para que el compilador pueda trabajar con ellos. Permite que puedan interactuar programas y componentes de la plataforma. Y CLS, Common Language Specification, son las reglas y estándares que brindan interoperabilidad entre distintas partes de la plataforma, distintos tipos de interacciones. Siguiendo estas reglas distintos programas son compatibles entre sí.


Explique con sus palabras que es un Assembly, el early y late Binding

Un Assembly es un archivo con tipos, recursos e información de metadatos. Es reutilizable y puede ser referenciado por otros archivos. Define el control de acceso a estos tipos y recursos lo que los hace importante al momento de pensar en la seguridad. Estos tipos y recursos que contienen pueden ser clases, estructuras y archivos de recursos entre otros. El Assembly no está limitado a un archivo, puede ser ejecutable o no. El early binding es cuando el código que se genera es conocido por el compilador por ejemplo primero definimos una clase (métodos incluidos) y luego la instanciamos y llamamos a uno de sus métodos, si uno de los métodos no llegara a existir el compilador va a avisar. En el caso del late binding el compilador no lo conoce de antemano porque se está generando o modificando en tiempo de ejecución, recién lo conoce cuando se ejecuta esa línea de código ahí se realiza la verificación, si no llegara a existir el método va a haber un error en tiempo de ejecución, el compilador compila sin problemas.


¿Qué es GIT? ¿Es centralizado o distribuido? Ejemplifique al menos 3 comandos de git y explique su funcionamiento

GIT es un controlador de versiones, un sistema que guarda la información, a diferencia de los otros, como snapshots. Y es distribuído porque cada equipo/computadora que tenga una copia del proyecto va a tener todas las versiones de los archivos que lo forman, las versiones anteriores no solo se encuentran en el servidor.

git status: muestra el estado del espacio de trabajo, se ven los cambios realizados, si los archivos están en preparación, a cuáles git les hace un seguimiento, si la rama está actualizada
Ej: usarlo antes de un git add
git status
//vemos si todo está en orden y si es aspi se agrega
git add .

git stash: se utiliza para guardar temporalmente los cambios locales que se realizaron en un directorio, así se puede volver trabajar con una 'versión limpia'. Es como revertir los cambios para tener la versión a la que se le hizo el pull. La versión guardada tiene su propio índice. Ej: guardar los cambios locales para trabajar en otra cosa,lo primero no está terminado así que almacena en el stash
git status
//vemos los cambios que vamos a guardar y los mandamos al stash
git stash

git checkout: su función principal es cambiar de una rama a otra. También se puede usar para crear una rama si se agrega -b y no existe, si existe se resetea la rama
Ej: pasar a la rama llamada creacion-menu
git checkout creacion-menu