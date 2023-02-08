using DI.Extended;
using System.Security.Principal;

//On respect bien le fait de fermer notre code mais on peut l'étendre
//De plus chaque class à sa propre responsabilité
//interception de ConsoleMessageWriter avec notre decorator SecureMessageWriter
IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter(), WindowsIdentity.GetCurrent());

//Salutation ne sait pas que l'on a ajouté un secureMessageWriter
Salutation salutation = new Salutation(writer); // injection par le constructeur via un paramètre

salutation.Exclaim();
