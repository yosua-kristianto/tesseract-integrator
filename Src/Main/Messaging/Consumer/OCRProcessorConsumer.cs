using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesseract_integrator.Src.Main.Messaging.Consumer
{
    public class OCRProcessorConsumer: BaseMessaging
    {
        public static string TOPIC = "IMAGE_OCR_OPERATION_TOPIC";

        public OCRProcessorConsumer(IConfiguration config): base(config){}

    }
}
