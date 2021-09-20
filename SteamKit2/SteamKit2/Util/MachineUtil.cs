using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SteamKit2.Util
{
    static class MachineUtil
    {
        internal static byte[] Get()
        {
            Random rd = new Random();
            var machine = new HardwareUtils.MachineID();
            machine.SetBB3( GetRandomStr( rd.Next(8, 13) ) );
            machine.SetFF2( GetRandomMacAddress() );
            machine.Set3B3( GetRandomStr( rd.Next(9, 16) ) );

            using MemoryStream ms = new MemoryStream();
            machine.WriteToStream( ms );
            return ms.ToArray();
        }

        static string GetRandomStr( int length )
        {
            Random rd = new Random( Guid.NewGuid().GetHashCode() );
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return GetHexString( Encoding.UTF8.GetBytes( new string( Enumerable.Repeat( chars, length )
                .Select( s => s[ rd.Next( s.Length ) ] ).ToArray() ) ) );
        }

        static string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[ 6 ];
            random.NextBytes( buffer );
            return string.Join( string.Empty, buffer.Select( x => $"{x:X2}" ) );
        }

        static string GetHexString( byte[] data )
        {
            data = CryptoHelper.SHAHash( data );

            return BitConverter.ToString( data )
                .Replace( "-", "" )
                .ToLower();
        }
    }
}
