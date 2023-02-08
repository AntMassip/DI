using DI;

IMessageWriter writer= new ConsoleMessageWriter();

Salutation salutation = new Salutation(writer); // injection par le constructeur via un paramètre

salutation.Exclaim();
