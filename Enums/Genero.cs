using System.ComponentModel;

namespace questionario_tcc_api.Enums
{
    public enum Genero
    {
        [Description("Masculino")]
        Masculino = 0,
        [Description("Feminino")]
        Feminino = 1,
        [Description("Trangênero")]
        Trangenero = 2,
        [Description("Outro")]
        Outro = 3,
        [Description("Prefiro não informar")]
        NDefinir = 4,
    }
}
