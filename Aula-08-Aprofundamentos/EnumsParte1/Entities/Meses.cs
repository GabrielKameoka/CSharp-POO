using System;
namespace EnumsParte1;
public enum Meses
{
    Janeiro = 1,
    Fevereiro = 2,
    Marco = 3,
    Abril = 4,
    Maio = 5,
    Junho = 6,
    Julho = 7,
    Agosto = 8,
    Setembro = 9,
    Outubro = 10,
    Novembro = 11,
    Dezembro = 12,
}
public static class MesesExtensions
{
    public static string ToFriendlyString (this Meses mes)
    {
        return $"O mês do dia de hoje é {mes}";
    }
}