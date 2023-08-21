
#    ----------- ⚡🏎️ renta de autos 🏎️⚡ -------------

Esta api fue desarrollada por motivo de llevar a cabo conocimientos previos y ser ejecutados de manera que el proceso de construccion del mismo sea mas veloz y al mismo tiempo eficiente y correcto. Una practica por el simple hecho de superar las habilidades actuales llevandolas a un nivel superior.


#  Acompañamiento para la ejecución del proyecto


#### Como primer paso para probar el proyecto. Es necesario que se reemplacen las credenciales ya existentes por sus credenciales instaladas en su ordenador para efectuar la conexión a la base de datos. Ya sea virtual o local.


## ubicación del archivo en el proyecto


el archivo estara dentro de : RepairAPI/appsettings.Development.json

![ubicacion del archivo](/Media/ubCredenciales.png)


### Seguidamente, habiendo reemplazado las credenciales, es hora de generar las migraciones que brevemente nos permitirán poder iniciar nuestro servidor local y poder iniciar la API que es el eje focal del proyecto (en este caso ya tenemos la carpeta de migraciones alojada dentro el proyecto) para poder ejecutar las migraciones usar el siguiente comando




```c#
dotnet ef database update --project ./Percistencia/ --startup-project ./RepairAPI/
```






#### Ya habiendo realizado los pasos anteriores, la base de datos debería observarse de la siguiente manera. 




![base de datos](/Media/diagramadb.png)

#### En caso de que base de datos no se pueda visualizar en su entorno, cabe resaltar que necesita tener en su sistema la librería de herramientas de .net-ef la cual se instala con el siguiente comando (asegúrese de salir del proyecto y ejecutarlo de manera global en su ordenador)


```c#
dotnet tool install --global dotnet-ef
```

En caso de tener una versión anterior de la misma. Por favor realizar la respectiva actualización haciendo uso del siguiente comando:


```c#
dotnet tool update --global dotnet-ef
```

Cabe aclarar que el proyecto no está 100% culminado. Estar atento a esta documentación que será paulatinamente actualizada.



## Tecnologias Usadas

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original.svg" height="40" alt="mysql logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
</div>


## Soporte

para soporte y consultar adicionales, email angelgabrielorteg@gmail.com o enviame solicitud por discord!

## Authors

- [@Angel-ISO](https://www.github.com/Angel-ISO)

