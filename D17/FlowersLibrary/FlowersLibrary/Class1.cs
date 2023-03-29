using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;


namespace FlowersLibrary
{
    public enum FlowerType
    {
        Холодостойкие,
        Теплолюбивые,
        Теплостойкие
    }

    public class Flower
    {
        public string Name { get; set; }
        public int Temperature { get; set; }

        public Flower(string name, int temperature)
        {
            Name = name;
            Temperature = temperature;
        }

        public FlowerType GetFlowerType()
        {
            if (Temperature >= 0 && Temperature <= 10)
            {
                return FlowerType.Холодостойкие;
            }
            else if (Temperature > 10 && Temperature <= 27)
            {
                return FlowerType.Теплолюбивые;
            }
            else if (Temperature > 27)
            {
                return FlowerType.Теплостойкие;
            }
            else
            {
                throw new ArgumentException("Некорректное значение температуры");
            }
        }
    }
}