using MailKit;
using MailKit.Net.Proxy;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Dummies
{
    public class DummyMail : ISmtpClient
    {
        public SmtpCapabilities Capabilities => throw new NotImplementedException();

        public string LocalDomain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public uint MaxSize => throw new NotImplementedException();

        public DeliveryStatusNotificationType DeliveryStatusNotificationType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object SyncRoot => throw new NotImplementedException();

        public SslProtocols SslProtocols { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public X509CertificateCollection ClientCertificates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CheckCertificateRevocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPEndPoint LocalEndPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProxyClient ProxyClient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HashSet<string> AuthenticationMechanisms => throw new NotImplementedException();

        public bool IsAuthenticated => throw new NotImplementedException();

        public bool IsConnected => throw new NotImplementedException();

        public bool IsSecure => throw new NotImplementedException();

        public bool IsEncrypted => throw new NotImplementedException();

        public bool IsSigned => throw new NotImplementedException();

        public int Timeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler<MessageSentEventArgs> MessageSent;
        public event EventHandler<ConnectedEventArgs> Connected;
        public event EventHandler<DisconnectedEventArgs> Disconnected;
        public event EventHandler<AuthenticatedEventArgs> Authenticated;

        public void Authenticate(ICredentials credentials, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Authenticate(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Authenticate(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Authenticate(string userName, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Authenticate(SaslMechanism mechanism, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateAsync(ICredentials credentials, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateAsync(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateAsync(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateAsync(string userName, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateAsync(SaslMechanism mechanism, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Connect(string host, int port, bool useSsl, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Connect(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Connect(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Connect(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ConnectAsync(string host, int port, bool useSsl, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ConnectAsync(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ConnectAsync(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ConnectAsync(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(bool quit, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DisconnectAsync(bool quit, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public InternetAddressList Expand(string alias, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<InternetAddressList> ExpandAsync(string alias, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void NoOp(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task NoOpAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Send(MimeMessage message, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public void Send(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public void Send(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public void Send(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(MimeMessage message, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default, ITransferProgress progress = null)
        {
            throw new NotImplementedException();
        }

        public MailboxAddress Verify(string address, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<MailboxAddress> VerifyAsync(string address, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
