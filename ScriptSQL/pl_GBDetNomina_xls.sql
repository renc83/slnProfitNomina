/*====================================================================
Author: Rafael Niño
Create date: 12/06/2024
Modulo: Profit Nomina
Description SP:  Detalle nominas procesadas, para generar archivo xls.


Ejemplo:
EXEC pl_GBDetNomina_xls 
 @COD_EMPRESA	='PSUMINOX_N'
,@CO_GENNOMI	=20
=======================================================================*/
USE MasterProfitPro
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pl_GBDetNomina_xls]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pl_GBDetNomina_xls
go
CREATE PROCEDURE pl_GBDetNomina_xls
(@COD_EMPRESA		VARCHAR(21)
,@CO_GENNOMI		INT
)
AS
BEGIN

SET NOCOUNT ON;
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

	SET @SQLSTR=CONCAT(' SELECT  CONVERT(nvarchar(20),N.fec_emis,103) Fecha
		,G.des_gennomi	Referencia
		,''PEN''			Moneda
		,''VENDER DIA''	TipoTasa
		,''''				TipoCambio
		,ISNULL(C.campo1,'''')	CuentaNumero
		,REPLACE(E.ci,''.'','''')	ClienteProveedor
		,IIF(N.tipo IN (3,2),N.monto,0)  Debito
		,IIF(N.tipo = 1,N.monto,0)		 Credito
		,C.des_conce Descripcion
		,ISNULL(D.campo1,'''')		Area
        --,G.co_gennomi,G.co_cont,E.nombre_completo		
   FROM ',@COD_EMPRESA,'.DBO.snnomi N
  INNER JOIN ',@COD_EMPRESA,'.DBO.snconcep  C on N.co_conce = C.co_conce
  INNER JOIN ',@COD_EMPRESA,'.DBO.snrecibo  R ON N.reci_num=R.reci_num
  INNER JOIN ',@COD_EMPRESA,'.DBO.sngennomi G ON R.co_gennomi=G.co_gennomi
  INNER JOIN ',@COD_EMPRESA,'.DBO.snemple   E on N.cod_emp = E.cod_emp
   LEFT JOIN ',@COD_EMPRESA,'.DBO.sndepart  D ON D.co_depart=E.co_depart
 WHERE  G.co_gennomi=@CO_GENNOMI and N.tipo IN (3,2,1) ')

   SET @Parametro = N'@CO_GENNOMI INT';  

   print @SQLSTR
   EXECUTE sp_executesql @SQLSTR, @Parametro,  
						 @CO_GENNOMI=@CO_GENNOMI;


SET NOCOUNT OFF;
END

