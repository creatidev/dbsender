using MiniExcelLibs.Attributes;

namespace DBSender.Classes
{
    /// <summary>
    /// Excel file columns
    /// </summary>
    public class Data
    {
        [ExcelColumnName("Filial")]
        public dynamic Filial { get; set; }

        [ExcelFormat("YYYY-MM-DD")]
        [ExcelColumnName("Fch_Contab")]
        public dynamic Fch_Contab { get; set; }

        [ExcelColumnName("Mes_Contab")]
        public dynamic Mes_Contab { get; set; }

        [ExcelColumnName("Tipo_contab")]
        public dynamic Tipo_contab { get; set; }

        [ExcelColumnName("Nro_Asiento")]
        public dynamic Nro_Asiento { get; set; }

        [ExcelColumnName("Cta_Local")]
        public dynamic Cta_Local { get; set; }

        [ExcelColumnName("Desc_Cta_Local")]
        public dynamic Desc_Cta_Local { get; set; }

        [ExcelColumnName("Cta_Grupo")]
        public dynamic Cta_Grupo { get; set; }

        [ExcelColumnName("Desc_Cta_Grupo")]
        public dynamic Desc_Cta_Grupo { get; set; }

        [ExcelColumnName("Moneda")]
        public dynamic Moneda { get; set; }

        [ExcelColumnName("Valor_Histórico")]
        public dynamic Valor_Histórico { get; set; }

        [ExcelColumnName("Naturaleza")]
        public dynamic Naturaleza { get; set; }

        [ExcelColumnName("Leyenda_Asiento")]
        public dynamic Leyenda_Asiento { get; set; }

        [ExcelColumnName("Proyecto")]
        public dynamic Proyecto { get; set; }

        [ExcelColumnName("Célula")]
        public dynamic Célula { get; set; }

        [ExcelColumnName("Responsable")]
        public dynamic Responsable { get; set; }

        [ExcelColumnName("Centro_Costo_ZPY")]
        public dynamic Centro_Costo_ZPY { get; set; }

        [ExcelColumnName("Item_Contable_ZPY")]
        public dynamic Item_Contable_ZPY { get; set; }

        [ExcelColumnName("Centro_Costo_C")]
        public dynamic Centro_Costo_C { get; set; }

        [ExcelColumnName("Item_Contable_C")]
        public dynamic Item_Contable_C { get; set; }

        [ExcelColumnName("Comp_CC")]
        public dynamic Comp_CC { get; set; }

        [ExcelColumnName("Comp_ITEMC")]
        public dynamic Comp_ITEMC { get; set; }

        [ExcelColumnName("UbicacionDRE")]
        public dynamic UbicacionDRE { get; set; }

        [ExcelColumnName("Clave_ValorZPY")]
        public dynamic Clave_ValorZPY { get; set; }

        [ExcelColumnName("Clase_ValorCT2")]
        public dynamic Clase_ValorCT2 { get; set; }

        [ExcelColumnName("Id_Cliente")]
        public dynamic Id_Cliente { get; set; }

        [ExcelColumnName("Grupo_Cliente")]
        public dynamic Grupo_Cliente { get; set; }

        [ExcelColumnName("Nombre_Cliente")]
        public dynamic Nombre_Cliente { get; set; }

        [ExcelColumnName("Nombre_RazaoSocial_CE")]
        public dynamic Nombre_RazaoSocial_CE { get; set; }

        [ExcelColumnName("Nombre_Fantasia_CE")]
        public dynamic Nombre_Fantasia_CE { get; set; }

        [ExcelColumnName("Industria_Cl")]
        public dynamic Industria_Cl { get; set; }

        [ExcelColumnName("Segmento")]
        public dynamic Segmento { get; set; }

        [ExcelColumnName("R_E_C_N_O_")]
        public dynamic R_E_C_N_O_ { get; set; }

        [ExcelColumnName("Nit")]
        public dynamic Nit { get; set; }
    }
}