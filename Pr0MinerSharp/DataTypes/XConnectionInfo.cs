using System;
using System.Net.Sockets;

namespace Pr0MinerSharp.DataTypes
{
    public class XConnectionInfo
    {
        public Socket Socket;

        public byte[] Buffer = new byte[1024 * 4];

        public string LastJobId { get; set; }

        public string Pr0User
        {
            get => String.IsNullOrEmpty(_pr0User) ? "WeLoveBurgers" : _pr0User;
            set => _pr0User = value;
        }

        private string _pr0User;

        public int Counter { get; set; } = 1;
        private bool _isDisposed = false;

        public bool LoginCompleted = false;

        public void Dispose()
        {
            if (_isDisposed) return;
            Console.WriteLine("Closing connection..");
            Socket?.Close();
            Socket?.Dispose();
            Socket = null;
        }
    }
}