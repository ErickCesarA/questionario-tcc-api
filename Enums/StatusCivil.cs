using System.ComponentModel;

namespace questionario_tcc_api.Enums
{
    public enum StatusCivil
    {
        [Description("Solteiro")]
        Solteiro = 0,
        [Description("Casado")]
        Casado = 1,
        [Description("Separado")]
        Separado = 2,
        [Description("Divorciado")]
        Divorciado = 3,
        [Description("Viúvo")]
        Viuvo = 4,
    }
}
