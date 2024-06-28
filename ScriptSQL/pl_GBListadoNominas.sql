/*====================================================================
Author: Rafael Niño
Create date: 12/06/2024
Modulo: Profit Nomina
Description SP:  Lista las nominas procesadas.
Tablas: 
select * from sngennomi  where co_cont=03 

Ejemplo:
EXEC pl_GBListadoNominas 
 @COD_EMPRESA	='PSUMINOX_N'
,@DCONTRATO		='03'
,@HCONTRATO		='99'
,@FECHAINI		='20240101'
,@FECHAFIN		='20240331'
=======================================================================*/
USE MasterProfitPro
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pl_GBListadoNominas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pl_GBListadoNominas
go
CREATE PROCEDURE pl_GBListadoNominas
(@COD_EMPRESA		VARCHAR(21)
,@DCONTRATO			VARCHAR(12)
,@HCONTRATO			VARCHAR(12)
,@FECHAINI			DATE
,@FECHAFIN			DATE
)
AS
BEGIN

SET NOCOUNT ON;
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

	SET @SQLSTR=CONCAT('select co_gennomi,des_gennomi,co_cont,fec_ini,fec_fin,fec_emis 
						  FROM ',@COD_EMPRESA,'.DBO.sngennomi  NM
						 WHERE fec_emis BETWEEN (@FECHAINI)  AND (@FECHAFIN)
						  AND  co_cont BETWEEN (@DCONTRATO) AND (@HCONTRATO)')

   SET @Parametro = N'@DCONTRATO VARCHAR(12),@HCONTRATO	VARCHAR(12),@FECHAINI DATE,@FECHAFIN DATE';  

   --INSERT INTO @ENCABEZADO
   EXECUTE sp_executesql @SQLSTR, @Parametro,  
						 @DCONTRATO=@DCONTRATO,@HCONTRATO=@HCONTRATO,@FECHAINI=@FECHAINI,@FECHAFIN=@FECHAFIN;


SET NOCOUNT OFF;
END

