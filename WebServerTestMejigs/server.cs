using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace WebServerTestMejigs
{
    /// <summary>
    /// This is the server class
    /// </summary>
   
    public class Server
    {

        public Server(string[] args)
        {
            //url of the webserver + port
            const string url = "http://localhost:8080/";
            var root = args.Length > 0 ? args[0] : "";
            //Start a filesystem at the exe folders subfolder called Web, where all web files are hosted
            PhysicalFileSystem fileSystem = new PhysicalFileSystem(root + "Web");
            //configure the file system options
            FileServerOptions options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                FileSystem = fileSystem
            };
            //start the webserver
            WebApp.Start(url, builder => builder.UseFileServer(options));
            

        }
    }
}
