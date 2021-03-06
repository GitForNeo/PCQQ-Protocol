﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQ.Framework.Packets.Receive.Message;
using QQ.Framework.Sockets;

namespace QQ.Framework.Domains.Commands.ReceiveCommands.Login
{
    /// <summary>
    /// 发送QQ消息
    /// </summary>
    [ReceivePacketCommand(QQCommand.Message0x00CD)]
    public class SendingQQMessagesCommand : ReceiveCommand<Receive_0x00CD>
    {
        /// <summary>
        /// 发送QQ消息
        /// </summary>
        public SendingQQMessagesCommand(byte[] data, QQClient client) : base(data, client)
        {
            _packet = new Receive_0x00CD(data, client.QQUser);
            _event_args = new QQEventArgs<Receive_0x00CD>(client, _packet);
        }

        public override void Process()
        {
            _client.OnReceive_0x00CD(_event_args);
            
        }
    }
}
