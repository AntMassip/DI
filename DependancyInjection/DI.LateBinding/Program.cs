using DI.LateBinding;
using Microsoft.Extensions.Configuration;

//On va créer le writer  sans savoir le type (ConsoleMessageWriter) ainsi on peut très bien choisir d'affecter un autre writer
//Voir Constrained Construction anti-pattern dans le chapitre 5
IConfigurationRoot configuration = new ConfigurationBuilder()
                                             .SetBasePath(Directory.GetCurrentDirectory())
                                             .AddJsonFile("appsettings.json")
                                             .Build();

string typeName = configuration["messageWriter"];

Type type = Type.GetType(typeName, throwOnError: true);

IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);

//La classe Salution ne sait pas si on écrit dans la console, dans une db, un fichier...
Salutation salutation = new Salutation(writer);

salutation.Exclaim();