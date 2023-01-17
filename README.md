# PruebaTecnicaTalentus

_Para ejecutar este proyecto es necesario tener docker instalado._

_Se debe ejecutar el siguiente comando para montar la imagen de postgres en la maquina local y el appsettings configurado funcione._

```sh
docker run --name local-postgres -p 5432:5432 -e POSTGRES_PASSWORD=12345678 postgres:alpine
```
