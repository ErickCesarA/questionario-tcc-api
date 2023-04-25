using System.ComponentModel;

namespace questionario_tcc_api.Enums
{
    public enum HorasExercicios
    {
        [Description("menos de 1 hora")]
        poucoExercicio = 0,
        [Description("entre 1 a 2 horas")]
        medioExercicio = 1,
        [Description("mais de 2 horas")]
        muitoExercicio = 2,
    
    }
}
