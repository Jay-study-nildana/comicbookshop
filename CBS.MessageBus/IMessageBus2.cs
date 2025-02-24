using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBS.MessageBus
{
    public interface IMessageBus2
    {
        Task PublishMessage2(object message, string topic_queue_Name, string connectionString);
    }
}
