using System;
using System.Collections.Generic;
namespace ExercicioComposicao;
public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Departament Departament { get; set; }
    public List<HourContract> Contracts C{ get; set; }
}
