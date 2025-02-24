using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//note: this is the original message bus code which used a hard coded azure service bus connection string
//this code is being refactored to use a connection string from the appsettings.json file
//the refactored code is in the MessageBus2.cs file
//I am leaving it here for educational purposes
//Its not being used in the application
//and you can delete it if you want
// Feb 24th 2025.

namespace CBS.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(object message, string topic_queue_Name);
    }
}
