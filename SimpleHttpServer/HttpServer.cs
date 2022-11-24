using System.Net;
using System.Net.Sockets;
using System.Text;

namespace simplehttpserver
{
    public class HttpServer
    {
        public TcpListener? Controller { get; set; } 
        public int Port { get; set; }
        public int QuantityOfRequest { get; set; }

        public HttpServer(int port = 8080)
        {
            this.Port = port;
            try
            {
                this.Controller = new TcpListener(IPAddress.Parse("127.0.0.1"), this.Port);
                this.Controller.Start();
                System.Console.WriteLine($"Servidor rodando em http://localhost:{this.Port}");
                //Chamada assíncrona do método que chama o método de aguardar requsições
                Task HttpServer = Task.Run(() => AwaitRequests());
                // aguradndo finalizar a task
                HttpServer.GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Erro ao rodar o servidor no IP 127.0.0.1 porta: {this.Port}! Erro: {e.Message}");
            }

        }
        // Método para aguarda as requisições
        private async Task AwaitRequests()
        {
            while (true){
                Socket connection = await this.Controller.AcceptSocketAsync();
                this.QuantityOfRequest ++;

            //Chamada assincrona do método que processa as requisições
            Task Task = Task.Run(()=> RequestProcess(connection, this.QuantityOfRequest));
            }
        }

        // Método para procesasr as requisições
        private void RequestProcess(Socket connection, int requestnumber)
        {
            if(connection.Connected)
            {
                System.Console.WriteLine($"Processando request número: {requestnumber}");
                byte[] BytesRequest = new byte[1024];
                string TextRequest = Encoding.UTF8.GetString(BytesRequest)
                    .Replace((char)0, ' ').Trim();
                if(TextRequest.Length > 0)
                {
                    System.Console.WriteLine($"\n{TextRequest}\n");
                    connection.Close();                
                }
            }
            System.Console.WriteLine($"Conexão {requestnumber} finalizada!");
        }

    }
}