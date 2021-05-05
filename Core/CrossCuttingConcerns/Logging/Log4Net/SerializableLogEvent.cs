using log4net.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class SerializableLogEvent
    {
        LoggingEvent _loggingEvent;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }
        // <summary>
        /// Kim hangi methodu çağırdı
        /// </summary>
        

        public string UserName => _loggingEvent.UserName;
        public object Message => _loggingEvent.MessageObject;
    }

}
