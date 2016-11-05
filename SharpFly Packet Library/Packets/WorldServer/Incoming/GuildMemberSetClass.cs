﻿using SharpFly_Utility_Library.Enums;

namespace SharpFly_Packet_Library.Packets.WorldServer.Incoming
{
    public class GuildMemberSetClass
    {
        public Flags Flag;       // UP : 1, DOWN : 0
        public uint MasterID;
        public uint PlayerID;

        public GuildMemberSetClass(IncomingPacket packet)
        {
            Flag = (Flags)packet.ReadByte();
            MasterID = packet.ReadUInt();
            PlayerID = packet.ReadUInt();
        }
    }  
}
