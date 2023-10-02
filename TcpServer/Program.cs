using TcpServer.Adaptee;
using TcpServer.Adapter;
using TcpServer.Client;
using TcpServer.Target;

/* ================= ADAPT ================= */
/* Convert an Interface of a class into a another interface that the client expects. */

// Let's say that this is legacy http server. (I know i should use the DI container, but this is just a training.)
var httpServer1 = new HttpServer(new Http1());

httpServer1.ProcessRequest();
httpServer1.ReadPayload();
httpServer1.ProcessResponse();


// And now, I wan't to upgrade to Http2, but I don't wan't to rewrite all system. Simple, let's just *Adapt* that
var httpServer2 = new HttpServer(new HttpAdapter(new Http2()));

httpServer2.ProcessRequest();
httpServer2.ReadPayload();
httpServer2.ProcessResponse();
