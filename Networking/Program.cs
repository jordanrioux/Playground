﻿using Networking;

//TODO Renvoyer Mathis...

Console.WriteLine("Hello world");
var server = new Server(3000);
await server.Start();