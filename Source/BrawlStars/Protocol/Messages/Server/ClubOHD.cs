using BrawlStars.Logic;
using BrawlStars.Utilities.Netty;
using System;

namespace BrawlStars.Protocol.Messages.Server
{
    class ClubOHD : PiranhaMessage
    {
        public ClubOHD(Device device) : base(device)
        {
            Id = 24399;
        }

        public override void Encode()
        {
            Writer.WriteVInt(1);
            Writer.WriteVInt(1);
            Writer.WriteVInt(25);
            Writer.WriteVInt(2);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(9);
            Writer.WriteVInt(-29);
            Writer.WriteVInt(-20);
            Writer.WriteVInt(-11);
            Writer.WriteVInt(-30);
            Writer.WriteVInt(32);
            Writer.WriteVInt(-18);
            Writer.WriteVInt(-31);
            Writer.WriteVInt(-19);
            Writer.WriteVInt(-27);
            Writer.WriteVInt(8);
            Writer.WriteVInt(5);
            Writer.WriteVInt(3);
            Writer.WriteVInt(1);
            Writer.WriteVInt(Resources.Trophies);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString(Resources.Region);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-34);
            Writer.WriteVInt(-8147);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-35);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-39);
            Writer.WriteVInt(17);
            Writer.WriteVInt(-3450);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(9);
            Writer.WriteVInt(-29);
            Writer.WriteVInt(-20);
            Writer.WriteVInt(-11);
            Writer.WriteVInt(-30);
            Writer.WriteVInt(32);
            Writer.WriteVInt(-18);
            Writer.WriteVInt(-31);
            Writer.WriteVInt(-19);
            Writer.WriteVInt(-27);
            Writer.WriteVInt(8);
            Writer.WriteVInt(5);
            Writer.WriteVInt(3);
            Writer.WriteVInt(1);
            Writer.WriteVInt(Resources.Trophies);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString(Resources.Region);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(11);
            Writer.WriteVInt(-28);
            Writer.WriteVInt(-27);
            Writer.WriteVInt(-13);
            Writer.WriteVInt(-29);
            Writer.WriteVInt(-14);
            Writer.WriteVInt(-23);
            Writer.WriteVInt(-16);
            Writer.WriteVInt(-12);
            Writer.WriteVInt(-23);
            Writer.WriteVInt(-17);
            Writer.WriteVInt(-18);
            Writer.WriteVInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-3);
            Writer.WriteVInt(-472);
            Writer.WriteVInt(135);
            Writer.WriteVInt(9887);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-39);
            Writer.WriteVInt(17);
            Writer.WriteVInt(-3450);
            Writer.WriteScString("Brawl Private Server");
            Writer.WriteVInt(8);
            Writer.WriteVInt(5);
            Writer.WriteVInt(3);
            Writer.WriteVInt(1);
            Writer.WriteVInt(99999);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString(Resources.Region);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString("Server created by PhoenixFire and VitalikObject");
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteInt(1);
            Writer.WriteVInt(2);
            Writer.WriteVInt(99999);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString(Resources.Name);
            Writer.WriteVInt(100);
            Writer.WriteVInt(28000000);
            Writer.WriteVInt(43000000);
            Writer.WriteVInt(-1);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(12);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteScString(Resources.Name);
            Writer.WriteVInt(100);
            Writer.WriteVInt(28000000);
            Writer.WriteVInt(43000000);
            Writer.WriteVInt(-1);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-34);
            Writer.WriteVInt(-8137);
            Writer.WriteVInt(0);
            Writer.WriteVInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-33);
            Writer.WriteVInt(44);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(2);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-50);
            Writer.WriteVInt(-8145);
            Writer.WriteVInt(0);
            Writer.WriteVInt(11);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(1);
            Writer.WriteVInt(1);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(-3);
            Writer.WriteVInt(-472);
            Writer.WriteVInt(135);
            Writer.WriteVInt(-1040385);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
            Writer.WriteVInt(0);
        }
    }
}
