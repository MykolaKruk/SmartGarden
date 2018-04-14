using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden.Data
{
    public class FlowerpotInitializer
    {
        public static void Initialize(FlowerpotContext context)
        {
            if (!context.Flowers.Any())
            {
                context.Flowers.AddRange(
                    new Flower
                    {
                        Name = "Default"
                    },
                    new Flower
                    {
                        Name = "Flower1"
                    }, new Flower
                    {
                        Name = "Flower2"
                    }, new Flower
                    {
                        Name = "Flower3"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Humidities.Any())
            {
                context.Humidities.AddRange(
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 30,
                        FlowerId = 1
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 40,
                        FlowerId = 2
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 50,
                        FlowerId = 3
                    },
                    new Humidity
                    {
                        MinnimumPercentageHumidity = 60,
                        FlowerId = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
