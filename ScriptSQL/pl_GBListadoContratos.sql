/*====================================================================
Author: Rafael Niño
Create date: 12/06/2024
Modulo: Profit Nomina
Description SP:  Lista las nominas procesadas.
Tablas: 
select * from sngennomi  where co_cont=03 

Ejemplo:
EXEC pl_GBListadoContratos 
 @COD_EMPRESA	='PSUMINOX_N'
=======================================================================*/
USE MasterProfitPro
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pl_GBListadoContratos]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pl_GBListadoContratos
go
CREATE PROCEDURE pl_GBListadoContratos
(@COD_EMPRESA		VARCHAR(21)
)
AS
BEGIN

SET NOCOUNT ON;
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

	SET @SQLSTR=CONCAT('select RTRIM(co_cont) co_cont, des_cont  
						  FROM ',@COD_EMPRESA,'.DBO.sncont ')

   --INSERT INTO @ENCABEZADO
   EXECUTE sp_executesql @SQLSTR;


SET NOCOUNT OFF;
END
