using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesseract_integrator.Src.Main.Facade;

namespace tesseract_integrator.Src.Main.Messaging
{
    public abstract class BaseMessaging
    {
        protected string groupId { get; set; }
        protected string server { get; set; }

        public BaseMessaging(IConfiguration config)
        {
            this.groupId = KafkaConfigConstant.KAFKA_DEFAULT_GROUP_ID;
            this.server = config.GetValue<string>("KafkaServer") ?? "localhost:9092";
        }
    }
}
