
# SISTEMA DE CADASTRO DE CONTATOS

Aplicação de CRUD, utilizando ASP.NET MVC e banco de dados MySQL

![Generic badge](https://img.shields.io/badge/.NET-5.0-purple.svg)
![Generic badge](https://img.shields.io/badge/CSHARP-9-purple.svg)
![Generic badge](https://img.shields.io/badge/MYSQL-5.7-purple.svg)

## FUNCIONALIDADES
- CRUD de dados (Create, Read, Update e Delete);

## PRÉ-REQUISITOS
- VISUAL STUDIO 2019 (Recomendado)
- .NET 5.0

## PACOTES NUGET
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation 5.0.16
- Dapper 2.0.123
- MySQL.Data 8.0.28
- Microsoft.EntityFrameworkCore.Tools 5.0.16
- Microsoft.EntityFrameworkCore 5.0.16

## ESTRUTURA Do PROJETO
```
+---Properties
+---wwwroot
+---Controllers
|   +---HomeController.cs
|   +---ContatoController.cs
+---Models
|   +---ContatoModels.cs
|   +---ErrorViewModel.cs
+---Repository
|   +---ContatoRepository.cs
|   +---IContatoRepository.cs
+---Views
|   +---Contato
|   |   +---Criar.cshtml
|   |   +---Editar.cshtml
|   |   +---Excluir.cshtml
|   |   +---Index.cshtml
|   +---Home
|   |   +---Index.cshtml
|   |   +---Privacy.cshtml
|   +---Shared
|   |   +---_Layout.cshtml
|   |   +---_ValidationScriptPartial.cshtml
|   |   +---Error.cshtml
|   +---_ViewImports.cshtml
|   +---_ViewStart.cshtml
appsettings.json
Program.cs 
Startup.cs
```
## BANCO DE DADOS 

```sql
MySQL - 5.7.34-37-log : Database - dtm_teste_guilherme
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
USE `dtm_teste_guilherme`;

/*Table structure for table `contato` */

DROP TABLE IF EXISTS `contato`;

CREATE TABLE `contato` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `number` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `contato` */

insert  into `contato`(`id`,`name`,`email`,`number`) values 
(3,'Miguel Alterado','guilherme5932.ms@gmail.com','222'),
(4,'Teste1','value2','value3'),
(5,'Guilherme','a@a.com','2213423'),
(6,'João','joao@gmail.com','214234524');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
```
## COMPILAÇÃO
1. Abra a solução do projeto no Visual Studio 2019;
2. Pressione Ctrl+F5;
3. Uma nova guia será aberta no seu navegador no endereço `http://localhost`;
