using System.ComponentModel;

namespace questionario_tcc_api.Enums
{
    public enum AnosCafeleia
    {
        [Description("menos de 1 mês")]
        menos1 = 0,
        [Description("entre 1 e 3 mêses")]
        entre1_3 = 1,
        [Description("entre 3 e 6 mêses")]
        entre3_6 = 2,
        [Description("entre 6 mêse e 1 ano")]
        entre6_1 = 3,
        [Description("mais de 1 ano")]
        mais1 = 4,
    }
}
